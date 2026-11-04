using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Kortleser
{
    public partial class Kortleser_GUI : Form
    {
        string kommunikasjonsportTilSimsim = "COM7";
        SerialPort sp;
        string data; // En slags buffer for all data som er mottatt
        string enMelding;
        bool kommunikasjonPågår;
        bool alarm = false;
        bool forrige_Alarm;
        bool dørLåst = true;
        bool forrige_dørLåst;
        bool dørÅpen = false;
        bool forrige_dørÅpen;



        public Kortleser_GUI()
        {
            InitializeComponent();
        }

        private void Kortleser_GUI_Load(object sender, EventArgs e)
        {
            // Skriver ut lokasjonen til aktiv kortleser
            tbLokasjon.Text = kortleser_info.valgtKortleser.ToString();
            sp = null;
            data = "";
            enMelding = "";
            kommunikasjonPågår = false;
            startKommunikasjon();
        }
        private void kortleser_GUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Setter valgt tilbake til ukejnt for å unngå feil ved neste valg.
            kortleser_info.valgtKortleser = "UKJENT";
        }
        bool SjekkOmAlarmPå(string enMelding)
        {
            bool alarm = false;
            int posF = enMelding.IndexOf("F");
            try
            {
                if (posF != -1)
                {
                    string str_verdi = enMelding.Substring(posF + 1, 4);
                    int Everdi = Convert.ToInt32(str_verdi);
                    if (Everdi > 500) alarm = true;
                }
                else
                {
                    throw new Exception("Finner ikkje E feltet!");
                }
            }
            catch (Exception e) { }


            return alarm;
        }
        private bool SjekkOmAlarmAv()
        {
            bool alarm = true;
            int posF = enMelding.IndexOf("F");
            try
            {
                if (posF != -1)
                {
                    string str_verdi = enMelding.Substring(posF + 1, 4);
                    int Everdi = Convert.ToInt32(str_verdi);
                    if (Everdi < 500) alarm = false;
                }
                else
                {
                    throw new Exception("Finner ikkje E feltet!");
                }
            }
            catch (Exception e) { }
            return alarm;
        }

        void SjekkTilstand(string melding)
        {

        }

        string TaUtEnHelMelding(string data, out string melding)
        {
            int indeksStart = data.IndexOf('$');
            int indeksSlutt = data.IndexOf('#');
            melding = "";
            if ((indeksStart >= 0) && (indeksSlutt > 0))
            {
                if (indeksSlutt > indeksStart)
                {
                    melding = data.Substring(indeksStart, (indeksSlutt - indeksStart) + 1);
                    data = data.Substring(indeksSlutt + 1);
                }
                else data = data.Substring(indeksSlutt + 1);
            }
            return data;
        }

        string LesData(SerialPort sp, out bool kommunikasjonPågår)
        {
            string svar = "";
            try
            {
                svar = sp.ReadExisting();
                kommunikasjonPågår = true;
            }
            catch (Exception e)
            {
                // Console.WriteLine("Feil! " + e.Message);
                kommunikasjonPågår = false;
            }
            return svar;
        }

        private void startKommunikasjon()
        {
            sp = new SerialPort(kommunikasjonsportTilSimsim, 9600);

            try
            {
                sp.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Feil! " + ex.Message);
                throw;
            }

            if (sp.IsOpen)
            {
                sp.Write("$S001"); // Endrer simsim til å sende hvert 2.sek
                bwHentData.RunWorkerAsync();
                kommunikasjonPågår = true;
            }
        }


        // Tillater bare tall i kortID og PINkode, andre tegn ignoreres
        private void tbPINKode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e = validerInnput(e);
        }
        private void tbKortID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e = validerInnput(e);
        }
        private KeyPressEventArgs validerInnput(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) e.Handled = false;
            else if (char.IsControl(e.KeyChar)) e.Handled = false;
            else e.Handled = true;
            return e;
        }

        private void bwHentData_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(200);
            // Henter all data fra simsim
            data += LesData(sp, out kommunikasjonPågår);
        }

        private void bwHentData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Om en hel melding er mottatt, vis på skjermen
            data = TaUtEnHelMelding(data, out enMelding);
            if (enMelding.Length > 0)
            {
                OppdaterGui(enMelding);
                OppdaterSimSim();
            }
            if (kommunikasjonPågår) bwHentData.RunWorkerAsync();
        }

        void OppdaterGui(string melding)
        {
            forrige_Alarm = alarm;

            bool nyAlarm = SjekkOmAlarmPå(melding);

            alarm = nyAlarm;

            // Vis dialogen bare når alarmen går fra av til på
            //if (!forrige_Alarm && alarm)
            //{
            //    MessageBox.Show(
            //        "Alarm er aktiv!",
            //        "Alarm",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Warning);
            //}
        }
        private void OppdaterSimSim()
        {
            if (dørLåst != forrige_dørLåst)
            {
                if (dørLåst) sp.Write("$O51");
                else if (!dørLåst) sp.Write("$O50");
                forrige_dørLåst = dørLåst;
            }


            if (dørÅpen != forrige_dørÅpen)
            {
                if (dørÅpen) sp.Write("$O61");
                else if (!dørÅpen) sp.Write("$O60");
            }

            if (alarm != forrige_Alarm)
            {
                if (alarm)
                {
                    sp.Write("$O71");
                    lAlarm.Visible = true;
                }
                else if (!alarm)
                {
                    sp.Write("$O70");
                    lAlarm.Visible = false;
                }
            }

        }

        private void Kortleser_GUI_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            kommunikasjonPågår = false;
            sp.Close();
        }

        private void btnBekreft_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stemmer det","JADA",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }
    }
}

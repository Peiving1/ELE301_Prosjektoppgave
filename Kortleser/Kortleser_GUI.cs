using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kortleser
{
    public partial class Kortleser_GUI : Form
    {
        public Kortleser_GUI()
        {
            InitializeComponent();
        }

        private void Kortleser_GUI_Load(object sender, EventArgs e)
        {
            // Skriver ut lokasjonen til aktiv kortleser
            tbLokasjon.Text = kortleser_info.valgtKortleser.ToString();
        }
        private void kortleser_GUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Setter valgt tilbake til ukejnt for å unngå feil ved neste valg.
            kortleser_info.valgtKortleser = "UKJENT";
        }


        // Tillater bare tall i kortID og PINkode, andre tegn ignoreres
        private void tbPINKode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) e.Handled = false;
            else e.Handled = true;
        }
        private void tbKortID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) e.Handled = false;
            else e.Handled = true;
        }
    }
}

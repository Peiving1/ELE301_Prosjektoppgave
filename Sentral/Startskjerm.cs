using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Sentral
{
    public partial class Startskjerm : Form
    {
        Server ser = new Server();

        public Startskjerm()
        {
            InitializeComponent();
            ser.LoggMelding += Server_Message; // Abonnerer på LoggMelding-hendelsen
        }
        private void Startskjerm_Load(object sender, EventArgs e)
        {
            // Oppretter en ny tråd for å starte serveren
            Thread serverTråd = new Thread(ser.StartServer);
            serverTråd.IsBackground = true; // Gjør tråden til en bakgrunnstråd
            serverTråd.Start();
            //Server server = new Server();
            
        }





        private void Server_Message(object? sender, string message)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action<object?, string>(Server_Message), sender, message);
                return;
            }

            lblogg.Items.Add(message); // UI thread
        }


        // Åpner vinduer for å genere rapporter og administrere systemet
        private void btnRapporter_Click(object sender, EventArgs e)
        {
            Rapporter rapporterForm = new Rapporter();
            rapporterForm.ShowDialog();
        }

        private void btnAdministrasjon_Click(object sender, EventArgs e)
        {
            Administrasjon administrasjonForm = new Administrasjon();
            administrasjonForm.ShowDialog();
        }

        private void OppdaterLogg_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }
    }
}

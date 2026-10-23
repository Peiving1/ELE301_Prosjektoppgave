namespace Kortleser
{
    public partial class Startskjerm : Form
    {
        public Startskjerm()
        {
            InitializeComponent();
        }
        

        private void Startskjerm_Load(object sender, EventArgs e)
        {
            OppdaterKortleserListe();
        }


        // TODO:
        // Sette opp en klient som kommuniserer med sentralen for å hente tilgjengelige kortlesere, og form annen kom
        // Sette opp kommunikasjon mot simsim, kan nok bare kopiere mye av koden som vi har skrevet allerede
        // Bør nok lage en klasse for å håndtere kommunikasjon mot sentralen, og en klasse for å håndtere kommunikasjon mot simsim


        void btnok_Click(object sender, EventArgs e)
        {
            kortleser_info.valgtKortleser = cbKortleser.SelectedItem.ToString();
            Kortleser_GUI kortleser_GUI = new Kortleser_GUI();

            // skjuler startskjermen etter posisjon er valgt, og åpner kortleser i valgt posisjon
            // Når kortleser lukkes, vises startskjermen igjen
            this.Hide();
            kortleser_GUI.ShowDialog();
            this.Show();

        }

        void OppdaterKortleserListe()
        {
            List<string> kortlesere = kortleser_info.HentTilgjengleigeKortlesere();
            cbKortleser.Items.Clear();
            foreach (string kortleser in kortlesere)
            {
                cbKortleser.Items.Add(kortleser);
            }
            cbKortleser.SelectedIndex = 0;
        }
    }
}

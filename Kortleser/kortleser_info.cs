using System;
using System.Collections.Generic;
using System.Text;

namespace Kortleser
{
    internal class kortleser_info
    {
        // Variabel for å lagre valgt kortleser
        public static string valgtKortleser = "UKJENT";


        // TODO: Implementer metoden for å hente tilgjengelige kortlesere fra sentralen
        public static List<string> HentTilgjengleigeKortlesere()
        {
            List<string> kortlesere = new List<string>();
            // Hent tilgjengelige kortlesere fra systemet
            // Må her kommunisere med sentralen som skal snakke med databasen for å hente kortlesere
            // Legg til kortleserne i listen
            // Tenker å løse dette ved å sende en forespørsel til sentralen som returnerer en "liste", kortleserene seperert med komma el.
            kortlesere.Add("Kortleser 1");
            kortlesere.Add("Kortleser 2");
            kortlesere.Add("Kortleser 3");
            return kortlesere;
        }

        
    }
}

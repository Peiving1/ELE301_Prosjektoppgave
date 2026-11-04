using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;

namespace Kortleser
{
    internal class KommunikasjonSimsim
    {
        SerialPort sp;
        string data; // En slags buffer for all data som er mottatt
        string enMelding;
        bool kommunikasjonPågår;
        double HentTemperatur(string enMelding)
        {
            double temperatur = -31; // Verdi mellom -30 og +50 

            int posI = enMelding.IndexOf("I");
            try
            {
                if (posI != -1)
                {
                    string tempS = enMelding.Substring(posI + 1, 3);

                    int rawI = Convert.ToInt32(tempS);
                    temperatur = -30 + rawI * (50 - (-30)) / 150.0;
                }
                else
                {
                    throw new Exception("Finner ikkje temperaturfeltet I!");
                }
            }
            catch (Exception e) { }

            return temperatur;
        }

        string TaUtEnHelMelding(string data, out string melding)
        {
            int indeksStart = data.IndexOf('$');
            int indeksSlutt = data.IndexOf('#');
            melding = "";
            if ((indeksStart > 0) && (indeksSlutt > 0))
            {
                if (indeksSlutt > indeksStart)
                {
                    melding = data.Substring(indeksStart, (indeksSlutt - indeksStart) + 1);
                    data = data.Substring(indeksSlutt + 1);
                }
            }
            return data;
        }
    }
}

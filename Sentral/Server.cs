using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Sentral
{
    internal class Server
    {
        public event EventHandler<string> LoggMelding;

        public Server()
        {
        }
        
        public void StartServer()
        {
            Socket lytteSokkel = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint serverEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);
            lytteSokkel.Bind(serverEP);
            lytteSokkel.Listen(10);
            while (true)
            {
                OppdaterLogg("Venter på en klient ...");
                //LoggMelding?.Invoke(this, "Venter på en klient ...");
                // lblogg.Items.Add("Venter på en klient ...");
                Socket kommSokkel = lytteSokkel.Accept(); // blokkerende metode

                IPEndPoint klientEP = (IPEndPoint)kommSokkel.RemoteEndPoint;
                VisKommunikasjonsinfo(serverEP, klientEP);

                Thread t = new Thread(enKlinetTråd);
                t.Start(kommSokkel);
            }
            lytteSokkel.Close();
        }

        private void enKlinetTråd(object o)
        {
            Socket kommSokkel = o as Socket;

            bool harForbindelse = true;
            string mottattTekst;
            string sendtTekst;

            string hilsen = "Velkommen til en enkel testserver";
            SendData(hilsen, kommSokkel, out harForbindelse);

            while (harForbindelse)
            {
                // Mottar data fra klient
                mottattTekst = MottaData(kommSokkel, out harForbindelse);

                if (mottattTekst.Length > 0)
                {
                    // Viser mottatt tekst på skjerm
                    OppdaterLogg(mottattTekst);
                    // LoggMelding?.Invoke(this, mottattTekst);
                    //lblogg.Items.Add(mottattTekst);

                    sendtTekst = mottattTekst + "YES!";

                    SendData(sendtTekst, kommSokkel, out harForbindelse);
                }
            }
            kommSokkel.Close();
        }

        static string MottaData(Socket kommSokkel, out bool harForbindelse)
        {
            string svar = "";
            harForbindelse = true;
            byte[] dataSomBytes = new byte[1024];
            int antallBytesMottatt = 0;

            try
            {
                antallBytesMottatt = kommSokkel.Receive(dataSomBytes);
                svar = Encoding.ASCII.GetString(dataSomBytes, 0, antallBytesMottatt);
                if (svar.Length == 0) harForbindelse = false;
            }
            catch (Exception)
            {
                harForbindelse = false;
            }

            return svar;
        }

        static void SendData(string dataSomSendes, Socket kommSokkel, out bool harForbindelse)
        {
            byte[] dataSomBytes = new byte[1024];
            harForbindelse = true;

            try
            {
                dataSomBytes = Encoding.ASCII.GetBytes(dataSomSendes);
                kommSokkel.Send(dataSomBytes);
            }
            catch (Exception)
            {
                harForbindelse = false;
            }
        }


        void OppdaterLogg(string melding)
        {
            LoggMelding?.Invoke(this, melding);
        }

        void VisKommunikasjonsinfo(IPEndPoint serverEP, IPEndPoint? klientEP)
        {
            LoggMelding?.Invoke(this, $"Kommuniserer med {klientEP.Address}:{klientEP.Port}, bruker selv {serverEP.Address}:{serverEP.Port}");
        }
    }    
}

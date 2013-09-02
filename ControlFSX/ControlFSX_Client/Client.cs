using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.IO;

namespace ControlFSX_Client
{
    class Client
    {
        NetworkStream networkStream;
        static void Main(string[] args)
        {
            Client cl = new Client();
            cl.Connect();
            cl.Close();

            Console.WriteLine("LISTO");
        }
        public void Connect()
        {
            TcpClient socketForServer;
            string server = "192.168.0.3";

            try
            {
                //Creamos un TcpCliente y le pasamos
                //el server y el puerto.
                socketForServer = new TcpClient(server, 7700);
            }
            catch
            {
                Console.WriteLine(
                "No se pudo conectar a {0}:7700", server);
                return;
            }

            //aqui es lo mismo que en el server. Usamos StreamWriter y Reader.
            networkStream = socketForServer.GetStream();

                StreamReader streamReader = new System.IO.StreamReader(networkStream);

                StreamWriter streamWriter = new System.IO.StreamWriter(networkStream);
                try
                {
                    string outputString = streamReader.ReadLine();
                    Console.WriteLine(outputString);
                    streamWriter.WriteLine("0B62 1 1");
                    streamWriter.Flush();
                }
                catch
                {
                    Console.WriteLine("Exception reading from Server");
                }
        }
        void Close()
        {
            networkStream.Close();
        }
    }
}
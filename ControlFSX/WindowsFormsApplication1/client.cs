using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.IO;

namespace WindowsFormsApplication1
{
    class client
    {
        TcpClient socketForServer;
        string server;
        NetworkStream networkStream;

        public String Connect(String Server, int Port)
        {
            
             server = Server;

            try
            {
                //Creamos un TcpCliente y le pasamos
                //el server y el puerto.
                socketForServer = new TcpClient(server, Port);
                return "Connected to " + server + ":" + Port.ToString();
            }
            catch
            {
                return "No se pudo conectar a "+server+":"+Port.ToString();
            }
        }
        public String Send(String Output){
            networkStream = socketForServer.GetStream();

            StreamReader streamReader = new System.IO.StreamReader(networkStream);

            StreamWriter streamWriter = new System.IO.StreamWriter(networkStream);
            try
            {
                string outputString = streamReader.ReadLine();
                return "Send: "+Output+"\nRecieved: "+outputString;

                streamWriter.WriteLine("0B62 1 1");
                streamWriter.Flush();
            }
            catch
            {
                return "Could not send";
            }
        }
    }
}

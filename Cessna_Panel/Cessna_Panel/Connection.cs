using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net.Sockets;

namespace Cessna_Panel
{
    class Connection
    {
        NetworkStream networkStream;
        public string answer;
        int port = 7700;

        public Connection(string server, string offset, string type, string value)
        {
            TcpClient socketForServer;

            try
            {
                socketForServer = new TcpClient(server, port);
                networkStream = socketForServer.GetStream();

                StreamReader streamReader = new System.IO.StreamReader(networkStream);

                StreamWriter streamWriter = new System.IO.StreamWriter(networkStream);
                try
                {
                    streamWriter.WriteLine(offset + " " + type + " " + value);
                    streamWriter.Flush();
                    answer = streamReader.ReadLine();
                }
                finally
                {
                    Close();
                }
            }
            catch
            {
              throw (new Exception("Connection Error"));
            }

        }
        public Connection(string server,int Port, string offset, string type, string value)
        {
            TcpClient socketForServer;
            port = Port;
            try
            {
                socketForServer = new TcpClient(server, port);
                networkStream = socketForServer.GetStream();

                StreamReader streamReader = new System.IO.StreamReader(networkStream);

                StreamWriter streamWriter = new System.IO.StreamWriter(networkStream);
                try
                {
                    streamWriter.WriteLine(offset + " " + type + " " + value);
                    streamWriter.Flush();
                    answer = streamReader.ReadLine();
                }
                finally
                {
                    Close();
                }
            }
            catch
            {
                throw (new Exception("Connection Error"));
            }

        }
        
        void Close()
        {
            networkStream.Close();
        }
    }
}

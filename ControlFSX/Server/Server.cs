using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Reflection;
using FSUIPC;

namespace Server
{
    public delegate void CessnaServerEventHandler(object sender, CessnaServerEventArgs e);
    public class CessnaServer
    {
        TcpListener tcpListener;
        NetworkStream networkStream;
        ServerForm form;
        public event CessnaServerEventHandler ServerEvent;
        public CessnaServer(ServerForm form_)
        {
            form = form_;
            form.Log.Text +="\nTrying to connect FSUIPC...";
            while (openFSUIPC())
            {
                System.Threading.Thread.Sleep(5000);
            }
            form.Log.Text += " [DONE]\r\n";
            form.Log.Text += "Starting reciving data...\r\n";
            Start();
        }
        public void Start()
        {
            // Creamos un TcpListener y le indicamos que
            //puerto va a poner en escucha.
            tcpListener = new TcpListener(System.Net.IPAddress.Any,7700);

            //Iniciamos la esucha
            tcpListener.Start();
            while (true)
            {
                //Este método queda bloqueado hasta que
                //se conecte un cliente
                Socket socketForClient = tcpListener.AcceptSocket();
                if (socketForClient.Connected)
                {
                    // Si se conecta
                    form.Log.Text += "Cliente conectado.\r\n";
                    //Creamos el networkSream, el Reader y el writer

                    networkStream =
                             new NetworkStream(socketForClient);

                    StreamWriter streamWriter =
                             new StreamWriter(networkStream);

                    StreamReader streamReader =
                             new StreamReader(networkStream);

                    try
                    {
                        //Escribimos la data en el stream

                        //Ahora le decimos que la mande.


                        string recivied = streamReader.ReadLine();
                        if (recivied.Split(' ')[0] == "RESTART")
                        {
                            //// Starts a new instance of the program itself
                            //System.Diagnostics.Process.Start(Assembly.GetExecutingAssembly().Location);
                            form.Log.Text += "RESTART\r\n";
                            //// Closes the current process
                            //Environment.Exit(0);
                            form.server_ServerEvent(this, new CessnaServerEventArgs("restart!!!"));
                        }
                        else
                        {
                            int offset = Convert.ToInt32(recivied.Split(' ')[0], 16);
                            Console.Write("Executing offset: ");
                            form.Log.Text += "Executing offset";
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(offset.ToString());
                            form.Log.Text += offset.ToString();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(" to state: ");
                            form.Log.Text += " to state: ";
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(recivied.Split(' ')[2]);
                            form.Log.Text += recivied.Split(' ')[2];

                            if (recivied.Split(' ')[1] == "HEX")
                            {
                                Offset<short> todoint16 = new Offset<short>(offset);
                                todoint16.Value = short.Parse(recivied.Split(' ')[2], System.Globalization.NumberStyles.AllowHexSpecifier);
                                Console.Write(recivied.Split(' ')[2]);
                                form.Log.Text += recivied.Split(' ')[2];
                            }
                            if (recivied.Split(' ')[1] == "request")
                            {
                                string Resp;
                                if (recivied.Split(' ')[2] == "HEX")
                                {
                                    Offset<short> todoint16 = new Offset<short>(offset);
                                    FSUIPCConnection.Process();
                                    Resp = todoint16.Value.ToString();
                                }
                                else
                                {
                                    Offset<int> todoint = new Offset<int>(offset);
                                    FSUIPCConnection.Process();
                                    Resp = todoint.Value.ToString();
                                }

                                streamWriter.WriteLine(Resp);
                                Console.Write(Resp);
                                form.Log.Text += Resp;
                            }
                            else
                            {
                                Offset<int> todoint = new Offset<int>(offset);
                                todoint.Value = Convert.ToInt32(recivied.Split(' ')[2]);
                                FSUIPCConnection.Process();
                            }

                            streamWriter.Flush();
                        }
                    }
                    catch(Exception)
                    {

                    }
                    finally
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t[DONE]");
                        form.Log.Text += "\t[DONE]\r\n";
                        Console.ForegroundColor = ConsoleColor.White;
                        //Cerramos las conexiones
                        streamReader.Close();
                        streamWriter.Close();
                        socketForClient.Close();
                    }
                }
            }
        }
        private Boolean openFSUIPC()
        {
            try
            {
                // Attempt to open a connection to FSUIPC (running on any version of Flight Sim)
                FSUIPCConnection.Open();
                return false;
            }
            catch (Exception)
            {
                form.Log.Text += "Flight Simulator not running\r\n";
                // Badness occurred - show the error message
                FSUIPCConnection.Close();
                return true;
            }
        }
        static byte[] IntToBCD(int input)
        {
            byte[] bcd = new byte[] { 
        (byte)(input>> 8), 
        (byte)(input& 0x00FF) 
    };
            return bcd;
        }
        public virtual void OnServerEvent(CessnaServerEventArgs e)
        {
            form.server_ServerEvent(this, e);
            //form.Log.Text += "OnServerEvent";
            ServerEvent(this, e);
        }  
    }

    public class CessnaServerEventArgs : EventArgs
    {
        public string message;

        public CessnaServerEventArgs(string _Event){
            message=_Event;

        }

    }
}
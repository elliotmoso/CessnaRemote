using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Reflection;
using FSUIPC;

namespace ControlFSX
{
    class Server
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int SW_MINIMIZE = 6;
        private const int SW_MAXIMIZE = 3;
        private const int SW_RESTORE = 9;

        TcpListener tcpListener;
        NetworkStream networkStream;
        static void Main(string[] args)
        {
            IntPtr winHandle =System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle;
            ShowWindow( winHandle, SW_MINIMIZE);
            Server srv = new Server();
            Console.Write("Trying to connect FSUIPC...");
            while (srv.openFSUIPC())
            {
                System.Threading.Thread.Sleep(5000);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" [DONE]\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Starting reciving data...");
            srv.Start();
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
                    Console.WriteLine("Cliente conectado.");
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
                            // Starts a new instance of the program itself
                            System.Diagnostics.Process.Start(Assembly.GetExecutingAssembly().Location);

                            // Closes the current process
                            Environment.Exit(0);

                        }
                        else
                        {
                            int offset = Convert.ToInt32(recivied.Split(' ')[0], 16);
                            Console.Write("Executing offset: ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(offset.ToString());
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(" to state: ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(recivied.Split(' ')[2]);
                            if (recivied.Split(' ')[1] == "HEX")
                            {
                                Offset<short> todoint16 = new Offset<short>(offset);
                                todoint16.Value = short.Parse(recivied.Split(' ')[2], System.Globalization.NumberStyles.AllowHexSpecifier);
                                Console.Write(recivied.Split(' ')[2]);
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
    }
}
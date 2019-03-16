using System;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace PDF246_Server_
{
    class Server
    {
        static void Main(string[] args)
        {
            NetworkStream stream = null;
            TcpListener tcpListerer = null;
            Socket clientsocket = null;
            StreamReader reader = null;
            StreamWriter writer = null;

            try
            {
                IPAddress ipAd = IPAddress.Parse("127.0.0.1");
                tcpListerer = new TcpListener(ipAd, 5001);
                tcpListerer.Start();

                clientsocket = tcpListerer.AcceptSocket();

                stream = new NetworkStream(clientsocket);
                Encoding encode = Encoding.GetEncoding("utf-8");

                reader = new StreamReader(stream, encode);
                writer = new StreamWriter(stream)
                {
                    AutoFlush = true
                }; 

                while (true)
                {
                    string str = reader.ReadLine();
                    Console.WriteLine(str);
                    writer.WriteLine(str);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                clientsocket.Close();
            }
        }
    }
}
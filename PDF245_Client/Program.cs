using System;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace PDF245_Client
{
    class TcpClientTest
    {
        static void Main(string[] args)
        {
            TcpClient client = null;
            StreamReader reader = null;
            try
            {
                client = new TcpClient();
                //client.Connect("192.168.0.18", 5001);
                client.Connect("localhost", 5001);
                NetworkStream stream = client.GetStream();
                StreamWriter writer = new StreamWriter(stream)
                {
                    AutoFlush = true
                };

                Encoding encode = Encoding.GetEncoding("utf-8");
                reader = new StreamReader(stream, encode);

                string dataToSend = Console.ReadLine();

                while (true)
                {
                    writer.WriteLine(dataToSend);
                    string str = reader.ReadLine();
                    Console.WriteLine("echo : {0}", str);
                    if (dataToSend.IndexOf("<EOF>") > -1) break;
                    dataToSend = Console.ReadLine();            
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                client.Close();
            }
        }
    }
}
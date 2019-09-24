using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Marvellous_Server
{
    class Program
    {
        public static string GetLocalIPAddress()
        {
            Console.WriteLine("Marvellous Web: Host Name-{0}", Dns.GetHostName());

            var host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }

            throw new Exception("Marvellous Web :No network adapters with an IPv4 address in the system..");
        }

        static void Main(string[] args)
        {
            Int32 MarvellousPort = 0;
            string MarvellousIP = null;
            Socket s = null;
            TcpListener mylist = null;

            try
            {
                MarvellousIP = GetLocalIPAddress();
                MarvellousPort = 21000;
                IPAddress ipAd = IPAddress.Parse(MarvellousIP);
                Console.WriteLine("Marvellous Web: Server Started..");
                mylist = new TcpListener(ipAd, MarvellousPort);
                mylist.Start();
                Console.WriteLine("Marvellous Web: Server started at point:" + MarvellousPort);
                Console.WriteLine("Marvellous Web: The local end point is:" + mylist.LocalEndpoint);
                Console.WriteLine("Marvellous Web: Server waiting for connection..");
                s = mylist.AcceptSocket();
                Console.WriteLine("Marvellous Web: Conncetion establish with client..");
                Console.WriteLine("Marvellous Web: Connection Accepted from : " + s.RemoteEndPoint);
                byte[] b = new byte[100];
                int k = s.Receive(b);
                Console.WriteLine("Marvellous Web: Message recived..");
                for (int i = 0; i < k; i++)
                {
                    Console.WriteLine(Convert.ToChar(b[i]));
                }
                ASCIIEncoding asen = new ASCIIEncoding();
                s.Send(asen.GetBytes("Marvellous Web: The string was recived by the server.."));
            }
            catch (Exception e)
            {
                Console.WriteLine("Marvellous Web Exception:" + e.StackTrace);
            }
            finally
            {
                Console.WriteLine("Marvellous Web: Deallocating all resources..");

                if (s != null)
                {
                    s.Close();
                }

                if (mylist != null)
                {
                    mylist.Stop();
                }
            }
        }
    }
}

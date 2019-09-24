using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.InteropServices;

namespace Marvellous_Client
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
            TcpClient tcpclient = null;
            Stream stm = null;
            Int32 MarvellousPort = 0;
            string MarvellousIP = null;

            try
            {
                MarvellousIP = GetLocalIPAddress();
                MarvellousPort = 21000;
                tcpclient = new TcpClient();
                Console.WriteLine("Marvellous Web: Connecting with Server..");
                tcpclient.Connect(MarvellousIP, MarvellousPort);
                Console.WriteLine("Marvellous Web: Connection Successful..");
                Console.WriteLine("Marvellous Web: Enter Message for Server..");
                string str = Console.ReadLine();
                Console.WriteLine("marvellous Web: Getting stream for data Transmission..");
                stm = tcpclient.GetStream();
                ASCIIEncoding asen = new ASCIIEncoding();
                byte[] ba = asen.GetBytes(str);
                Console.WriteLine("Marvellous Web: Sending Data..");
                byte[] bb = new byte[100];
                int k = stm.Read(bb, 0, 100);
                Console.WriteLine("Marvellous Web: Message Recived from Server..");
                for (int i = 0; i < k; i++)
                {
                    Console.Write(Convert.ToChar(bb[i]));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Marvellous Web Exception:" + e.StackTrace);
            }
            finally
            {
                Console.WriteLine("Marvellous Web: Deallocating all Resources..");

                if (tcpclient != null)
                {
                    tcpclient.Close();
                }
                if (stm != null)
                {
                    stm.Close();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Problem_Statement_1
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

            throw new Exception("No network adapter with an IP4v address in the System..");
        }

        static void Main(string[] args)
        {
            if (!(System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable()))
            {
                Console.WriteLine("Unable to connect Network..");
                return;
            }

            try
            {
                string ip = GetLocalIPAddress();

                Console.WriteLine("Marvellous Web: IP Address of your machine is:" +ip);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace String_Oriented_File_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Batches = new string[] { "PPA", "LB", "IPD", "LSP", "AWB", "C#", "Python with Automation" };

            using (StreamWriter sw = new StreamWriter("MarvellousBatches.txt"))
            {
                foreach (string s in Batches)
                {
                    sw.Write(s + "\t");
                }
            }

            string line = "";
            using (StreamReader sr = new StreamReader("MarvellousBatches.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.Write(line + "\t");
                }
            }
        }
    }
}

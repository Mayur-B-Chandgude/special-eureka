using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem_Statement_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo di = new DriveInfo(@"C:\");

            DirectoryInfo dirinfo = di.RootDirectory;

            FileInfo[] FileNames = dirinfo.GetFiles("*.*");

            foreach (FileInfo fi in FileNames)
            {
                Console.WriteLine("{0}:",fi.Name);
            }
        }
    }
}

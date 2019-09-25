using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem_Statement_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Directory Nmae:");
            string dirname = Console.ReadLine();

            Console.WriteLine("Enter File Name:");
            string filename = Console.ReadLine();

            MarvellousDirectory mobj = new MarvellousDirectory();

            mobj.Demo(dirname, filename);
        }
    }

    class MarvellousDirectory
    {
        public void Demo(string DirName, string FileName)
        {
            string pathstring = Path.Combine(DirName);

            Directory.CreateDirectory(pathstring);

            Path.GetFileNameWithoutExtension(pathstring);

            pathstring = Path.Combine(pathstring, FileName);

            Console.WriteLine("Path of My Directory and File is:{0}\n", pathstring);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Byte_Oriented_File_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream F = new FileStream("Marvellous.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            for (int i = 0; i <= 50; i++)
            {
                F.WriteByte((byte)i);
            }

            F.Position = 0;

            Console.WriteLine("Contents from file are:");

            for (int i = 0; i <= 50; i++)
            {
                Console.Write(F.ReadByte() + " ");
            }

            F.Close();
        }
    }
}

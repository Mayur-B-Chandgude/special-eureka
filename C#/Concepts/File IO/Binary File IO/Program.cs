using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Binary_File_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryWriter bw;
            BinaryReader br;

            int i = 65;
            double d = 3.141157;
            bool b = true;
            string s = "Marvellous Infosystem";

            try
            {
                bw = new BinaryWriter(new FileStream("MarvellousBinary", FileMode.Create));
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message + "\n cannot create File..");
                return;
            }

            try
            {
                bw.Write(i);
                bw.Write(d);
                bw.Write(b);
                bw.Write(s);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n cannot write to file");
                return;
            }

            bw.Close();

            try
            {
                br = new BinaryReader(new FileStream("MarvellousBinary", FileMode.Open));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n cannot open file");
                return;
            }

            try
            {
                i = br.ReadInt32();
                Console.WriteLine("Integer Data:{0}", i);

                d = br.ReadDouble();
                Console.WriteLine("Double Data:{0}", d);

                b = br.ReadBoolean();
                Console.WriteLine("Boolean Data:{0}", b);

                s = br.ReadString();
                Console.WriteLine("String Data:{0}", s);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n cannot read file");
                return;
            }

            br.Close();
        }
    }
}

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
            string text = File.ReadAllText(@"E:\MetaData\C Sharp\Program\23-10-2018\Assignment Number 16\notepad.txt");

            string path = @"E:\MetaData\C Sharp\Program\23-10-2018\Assignment Number 16\notepad.txt";

            string path_dest = @"E:\MetaData\C Sharp\Program\23-10-2018\Assignment Number 16\notepad1.txt";

            string searchstr = "mayurr";

            MarvellousFile mobj = new MarvellousFile(text);

            MarvellousFile mobj1 = new MarvellousFile(path);

            mobj1.Search_String(searchstr);
            
            //mobj1.Copy_File(path_dest);

            //mobj1.File_Extension();

            /*mobj1.Display_Time();
            int FileLength_Ret = mobj1.File_Length();
            Console.WriteLine("File Length is:{0} bytes", FileLength_Ret);*/

            //mobj.Display_Contents();
            //mobj.Delete_File();
        }
    }

    public class MarvellousFile
    {
        private string FileName;
        private FileInfo fobj;

        public MarvellousFile(string name)
        {
            FileName = name;
            fobj = new FileInfo(FileName);
        }

        public void Display_Contents()
        {
            Console.Write("Contents of File:{0}\n", fobj);
        }

        public void Delete_File()
        {
            if (File.Exists(FileName))
            {
                try
                {
                    File.Delete(FileName);
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }
        }

        public void Display_Time()
        {
            try
            {
                if (!File.Exists(FileName))
                {
                    File.Create(FileName);
                }
                else
                {
                    File.SetLastAccessTime(FileName, DateTime.Now);
                    DateTime dt = File.GetLastAccessTime(FileName);
                    Console.WriteLine("The last access time for this file was:{0}", dt);

                    //File.SetLastWriteTime(FileName, new DateTime(2017,11,13));
                }

                File.SetLastWriteTime(FileName, DateTime.Now);
                DateTime dt1 = File.GetLastWriteTime(FileName);
                Console.WriteLine("The last write time for this file was {0}.", dt1);
            }
            catch (Exception e)
            {
                Console.WriteLine("The Process Failed.." , e.ToString());
            }
        }

        public int File_Length()
        {
            byte filelength = 0;

            Console.WriteLine("File Name is:{0}", fobj.Name);
            filelength = (byte)fobj.Length;
            return filelength;
        }

        public void File_Extension()
        {
            string extension;

            extension = Path.GetExtension(FileName);

            Console.WriteLine("GetExtension ('{0}') returns '{1}'", FileName, extension);
        }

        public void Copy_File(string NewFile)
        {
            Console.WriteLine("Contents Before Copy:");
            string str1 = File.ReadAllText(FileName);
            Console.WriteLine(str1);
            string str2 = File.ReadAllText(NewFile);
            Console.WriteLine(str2);
            Console.WriteLine();

            try
            {
                File.Copy(FileName, NewFile,true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("Contents After Copy:");
            string str3 = File.ReadAllText(FileName);
            Console.WriteLine(str3);
            string str4 = File.ReadAllText(NewFile);
            Console.WriteLine(str4);
            Console.WriteLine();
        }

        public void Search_String(string str)
        {
            try
            {
                using (StreamReader sr = new StreamReader(FileName))
                {
                   string line;
                   while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains(str))
                        {
                            Console.WriteLine("String is found in file..");
                        }
                        else
                        {
                            Console.WriteLine("String is not present in file..");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}

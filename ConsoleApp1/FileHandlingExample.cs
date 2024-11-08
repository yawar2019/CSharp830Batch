using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FileHandlingExample
    {

        public static void Main(string[] args)
        {
            // Writing and appending
            //FileStream f = new FileStream("F:\\abc.txt", FileMode.Append);
            //for (int i = 65; i <= 99; i++)
            //{
            //    int s = 109;
            //    byte b = (byte)s;
            //    f.WriteByte((byte)b);

            //}
            //f.Close();


            //Reading Purpose

            //FileStream f = new FileStream("F:\\abc.txt", FileMode.OpenOrCreate);
            //int i = 0;
            //while((i=f.ReadByte())!=-1)
            //{
            //    Console.WriteLine((char)i);
            //}
            //f.Close();

            //Writing character infile

            //FileStream f = new FileStream("F:\\abc.txt", FileMode.Create);
            //StreamWriter s = new StreamWriter(f);

            //s.WriteLine("Hello Mankianta");

            //s.Close();
            //f.Close();

            //Reading single lien Character in file


            //  FileStream f = new FileStream("F:\\abc.txt", FileMode.OpenOrCreate);
            //  StreamReader s = new StreamReader(f);
            //string readdata=  s.ReadLine();

            //  Console.WriteLine(readdata);

            //  s.Close();
            //  f.Close();


            //Reading Multiple line Character in file


            FileStream f = new FileStream("F:\\abc.txt", FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);
            string AllLines = "";
            while((AllLines= s.ReadLine()) != null)
            {

                Console.WriteLine(AllLines);
            }


            s.Close();
            f.Close();


            Console.ReadLine();
        }
    }
}

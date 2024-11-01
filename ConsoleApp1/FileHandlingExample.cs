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

            FileStream f = new FileStream("F:\\TeamCSharp\\TestExample\abc.txt", FileMode.OpenOrCreate);
            f.WriteByte(67);
            f.Close();

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentClassLibrary;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args,int a)
        {
           

            int argInt = 0;int  aty=a;
            Console.WriteLine(aty);

            foreach (var arg in args)
            {
                  argInt = Convert.ToInt32(arg + 1) +1;
                Console.WriteLine(Convert.ToInt32(arg));
            }
            Console.ReadLine();


        }
    }
}




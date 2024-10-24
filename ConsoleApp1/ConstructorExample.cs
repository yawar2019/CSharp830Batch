using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Faculty
    {
        int a,  b;

        Faculty()
        {
            int d=99;
            Console.WriteLine("default Constructor is called"+d);
        }
        Faculty(int a,int b )
        {
             this.a = a;
            this.b = b;
            Console.WriteLine("paramaetrized  Constructor is called {0} ",a+b);
        }
        Faculty(int a, string b)
        {
            Console.WriteLine("paramaetrized  Constructor is called {0} ,{1}", a,b);
        }
        Faculty(string a, int b)
        {
            Console.WriteLine("paramaetrized  Constructor is called {0} ,{1}", a, b);
        }

        ~Faculty()
        {
            Console.WriteLine("Destructor is Called");
        }

        public static void Main()
        {

            Faculty obj = new Faculty();
            Faculty obj1 = new Faculty(10,20);
            Faculty obj2 = new Faculty(10, "kajal");
            Faculty obj3 = new Faculty("ajay devgan",1);

            Console.ReadLine();

        }




    }
}

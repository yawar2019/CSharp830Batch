using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public delegate string HelloDelagate(string name);
    internal class AnonymusMethod
    {

        //public string HelloWorld(string Name)
        //{
        //    return "Hello " + Name;
        //}
        public static void Main()
        {
          

            HelloDelagate objDel = delegate (string name)
            {
                return "Hello " + name;
            };
          Console.WriteLine(objDel.Invoke("Radha"));
            Console.ReadLine();
        
        }
    }
}

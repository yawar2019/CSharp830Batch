using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SortedListExample
    {
        public static void Main()
        {
            //SortedList s=new SortedList();
            //s.Add(1, "Amruta");
            //s.Add(0, 2);
            //s.Add(2, "xyz");

            ////foreach (DictionaryEntry item in s)
            ////{
            ////    Console.Write(item.Key+":");
            ////    Console.WriteLine(item.Value);
            ////}
            //Console.WriteLine(s[1]);


            SortedList<int, string> s = new SortedList<int, string>();
            s.Add(1, "Raghav");
            s.Add(10, "Kali");
            s.Add(4, "virender");

            foreach (KeyValuePair<int,string> item in s)
            {
                Console.Write(item.Key+":");
                Console.WriteLine(item.Value);
            }

            Console.ReadLine();
        }
    }
}

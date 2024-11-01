using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class EnumExample
    {
        public enum Days
        { Sunday=21,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday}

        public static void Main()
        {
            //Console.WriteLine(Days.Sunday);
            //Console.WriteLine((int)Days.Monday);


            foreach (var item in Enum.GetNames(typeof(Days)))
            {
                Console.WriteLine(item);
            }


            foreach (var item in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine((int)item);
            }

            Console.ReadLine();
        }
    }
}



//Enum in c# called as a Enumeration
//it is a collection of Named Constaant
//like Days,Seasons,Months
//outside of the class or inside of class we can declare 
//Enum will assign integer value for set of constant
//default value for Enum  start from 0 next increment by 1 values
//even you want to change enum value you can change
//for TypeSaftey Enums

//1 Monday
//2 Tuesday

//monday

//int i=Days.Monday
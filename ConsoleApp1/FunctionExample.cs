using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FunctionExample
    {

        public static void Main()
        {
            //string Function Example
            string str1 = "Hello World";
            //int length = str1.Length;

            //Console.WriteLine(length);11

            //str1 = str1.ToUpper();HELLO WORLD
            //str1 = str1.ToLower();hello world

            // str1 = str1.Trim();
            // str1 = str1.TrimStart();

            //str1 = str1.Substring(6,2);wo

            //str1 = str1.Replace("World", "Universe"); hello universe

            //int i= str1.IndexOf("World");//6
            //string [] str2=str1.Split('/');
            //str1=str2[0];

            // bool result = str1.Contains("5");
            // string res = string.Concat(str1,str2);

            //string[] str3 = new string [] { "the", "World", "is Silent Today"};
            //str1 = string.Join("-", str3);//the-World-is Silent Today


            ///str1 = str1.Remove(6,2);

            ///str1 = str1.Insert(6,"EveryOne to ");
            // Console.WriteLine(str1);

            //End for String Function

            //Beging Math Function

            /* int num = -4;

            int absolute=Math.Abs(num);*/
            /*
                       double num = 7.2;
                       int celling = (int)Math.Ceiling(num);//8 try to bring nearest and greater integral value RoundUp

                       Console.WriteLine(celling);
            */
            /*
                       double num = 7.9;
                       int floor=(int)Math.Floor(num);
                       Console.WriteLine(floor);//7 bring nearest less integral value like 7

           

            int num1 = 10,num2=15;
            //int result = Math.Max(num1, num2);
            int result = Math.Min(num1, num2);
                Console.WriteLine(result);
                 

            double basenum = 2;
            int exponential = 3;
            double res=Math.Pow(basenum, exponential);
            Console.WriteLine(res);
            

            double num1 = 144;

            double res=Math.Sqrt(num1);
            Console.WriteLine(res);

            double num1 = 12.8;
            double res =Math.Round(num1);
            Console.WriteLine(res);
            */

            //DateAndTimeFunction

            // DateTime dt1 = DateTime.Now; //10/25/2024 8:41:29 PM   

            //DateTime today = DateTime.Today; //10/25/2024 12:00:00 AM

            DateTime dt1 = DateTime.Now;
            DateTime futureDate = dt1.AddYears(3);//10/28/2024 8:46:00 PM

            //want to know date difference
            int datediff = (futureDate - dt1).Days;//3
            Console.WriteLine(datediff);                               //DateTime futureDate=dt1.AddHours(1);

            // Console.WriteLine(dt1.ToShortDateString());// 10 / 25 / 2024
            // Console.WriteLine(dt1.ToLongDateString());//Friday, October 25, 2024

            //string datestring = "2024-10-25";
            //  DateTime date = Convert.ToDateTime(datestring); 10 / 25 / 2024 12:00:00 AM
            // DateTime date1 = DateTime.Parse(datestring); 10 / 25 / 2024 12:00:00 AM

            //Console.WriteLine(dt1.ToString("yyyy-MM-dd"));//2024-10-25
            //Console.WriteLine(dt1.ToString("dd-MMM-yyyy"));//2024-10-25
            //Console.WriteLine(dt1.ToString("dd/MM/yyyy"));// 25 / 10 / 2024
            //Console.WriteLine(dt1.ToString("hh:mm:ss"));//09:04:52  small h-12 ,H-24


            Console.ReadLine();
      }
  }
}

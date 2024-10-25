using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal  static class Shopping
    {
         static int addToCart = 10;
        static Shopping() {
            addToCart = addToCart + 1;
        }
        public static int Add() {
            
       return addToCart;   
        }


        
    }

    internal static class addToMyCart
    {
       


        static void Main()
        {
            Shopping.Add();
            Shopping.Add();
           int res=Shopping.Add();
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}

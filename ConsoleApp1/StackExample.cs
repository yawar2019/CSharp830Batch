using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StackExample
    {
        public static void Main()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(3);
            stack.Push(2);
            stack.Pop();
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine(stack.Peek());

            Console.ReadLine();
        }
    }
}

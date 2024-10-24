using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class QueueExample
    {
        public static void Main()
        {
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Dequeue();
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(queue.Contains(3));


            List<Product> products = new List<Product>();

            Product p1= new Product();
            p1.Pid = 1211;
            p1.Pname = "Watch";
            p1.Price = 12000;

            Product p2 = new Product();
            p2.Pid = 1212;
            p2.Pname = "Shoes";
            p2.Price = 32000;

            Product p3 = new Product();
            p3.Pid = 1213;
            p3.Pname = "Ring";
            p3.Price = 42000;


            products.Add(p1);
            products.Add(p2);
            products.Add(p3);
            products.Add(p2);



            foreach (var item in products)
            {
                Console.Write("Pid:"+item.Pid);
                Console.Write(" Product:"+item.Pname);
                Console.WriteLine(" Price:"+item.Price);
            }

            Console.WriteLine("Product greater then 15000");

            //var productgretear15000 = products.Where(s => s.Price > 15000 && s.Pname== "Ring");

            //var productgretear15000 = from product in products
            //                          where   product.Pname== "Ring"
            //                          select product;



            Console.WriteLine();



            //var productgretear15000 = products.Take(1);
            ///var productgretear15000 = products.Skip(2);

            var productgretear15000=products.OrderByDescending(x => x.Pid).ToList();    

            foreach (var item in productgretear15000)
            {
                Console.Write("Pid:" + item.Pid);
                Console.Write(" Product:" + item.Pname);
                Console.WriteLine(" Price:" + item.Price);
            }

            //var productgretear25000 = products.Sum(x=>x.Pid);
            var productgretear25000 = products.Max(x => x.Pid);
            Console.WriteLine(productgretear25000);

            Console.ReadLine();
        }
    }

    internal class Product
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public int Price { get; set; }
    }
}

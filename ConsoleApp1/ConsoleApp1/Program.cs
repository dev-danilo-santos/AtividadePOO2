using System;
using System.Collections.Generic;
using ConsoleApp1.Entities;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Product #{i+1} data:");
                Console.Write("Common, used or imported (c/u/i)?");
                string type = Console.ReadLine().Trim().ToLower();
                Console.Write("Name product: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (type.Equals("c"))
                {
                    Product p = new Product(name, price);
                    list.Add(p);
                }

                else if (type.Equals("u"))
                {
                    Console.Write("Manufacture date (DD/MM/YYYY)");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    Product p = new UsedProduct(name, price, date);
                    list.Add(p);
                }

                else if (type.Equals("i"))
                {
                    Console.Write("Customs fee:");
                    double c = double.Parse(Console.ReadLine());
                    Product p = new ImportedProduct(name, price, c);
                    list.Add(p);
                }
            
            }

            list.ForEach(x => Console.WriteLine(x.priceTag()));

        }
    }
}

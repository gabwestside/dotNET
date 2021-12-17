using System;
using System.Collections.Generic;
using UsingMoreExamplesForHash.Entities;

namespace UsingMoreExamplesForHash
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.0));
            a.Add(new Product("Notebook", 1200.0));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.0);
            Console.WriteLine(a.Contains(prod));

            Point point = new Point(5, 10);
            Console.WriteLine(b.Contains(point));
        }
    }
}

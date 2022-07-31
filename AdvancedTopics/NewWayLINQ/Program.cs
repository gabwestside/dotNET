using System;
using System.Linq;

namespace NewWayLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 3, 10, 1, 4, 25, 2, 5, 12, 22, 11 };

            var querylist = from itens in list 
                            where itens > 10 
                            orderby itens 
                            select itens;
            int count = 1;

            foreach (var item in querylist)
            {
                Console.WriteLine($"#{count} item: " + item);

                count++;
            }

            Console.ReadKey();
        }
    }
}
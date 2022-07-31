using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 3, 10, 1, 4, 25, 2, 5, 12, 22, 11 };

            var querylist = list.Where(x => x > 10)
                                .OrderBy(x => x)
                                .Select(x => x);

            foreach (var item in querylist)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}

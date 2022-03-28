using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            var chico = 300 * Int32.Parse(Console.ReadLine());
            var bento = 1500 * Int32.Parse(Console.ReadLine());
            var bernardo = 600 * Int32.Parse(Console.ReadLine());
            var marina = 1000 * Int32.Parse(Console.ReadLine());
            var iara = 150 * Int32.Parse(Console.ReadLine());
            var marlene = chico + bento + bernardo + marina + iara + 225;
            var total = marlene;
            Console.WriteLine(total);
        }
    }
}
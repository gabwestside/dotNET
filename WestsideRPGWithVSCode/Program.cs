using System;
using WestsideRPGWithVSCode.src.Entities;

namespace WestsideRPGWithVSCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero();
            Hero boss = new Hero("Nemesis", 10, "Wizard");

            Console.WriteLine($"Hero's infos");
            Console.Write($"Name: ");

            string name = Console.ReadLine();
            hero.Name = name;

            Console.Write($"Level: ");

            int level = int.Parse(Console.ReadLine());
            hero.Level = level;

            Console.Write($"Type: ");

            string heroType = Console.ReadLine();
            hero.HeroType = heroType;

            Console.WriteLine($"");

            Console.WriteLine($"{hero}");

            Console.WriteLine($"");

            Console.WriteLine($"{boss}");
        }
    }
}

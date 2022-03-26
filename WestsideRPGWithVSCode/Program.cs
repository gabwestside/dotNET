using System;
using WestsideRPGWithVSCode.src.Entities;

namespace WestsideRPGWithVSCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Arus hero = new Arus();

            Console.WriteLine($"Hero's infos");
            Console.Write($"Name: ");

            string name = hero.Name;
            name = Console.ReadLine();

            Console.Write($"Level: ");

            int level = hero.Level;
            level = int.Parse(Console.ReadLine());

            Console.Write($"Type: ");

            string heroType = hero.HeroType;
            heroType = Console.ReadLine();

            Console.WriteLine($"Name: {hero.Name} \nLevel: {hero.Level} \nHero Type: {hero.HeroType}");
        }
    }
}

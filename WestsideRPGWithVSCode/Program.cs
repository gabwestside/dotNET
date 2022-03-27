using System;
using WestsideRPGWithVSCode.src.Entities;

namespace WestsideRPGWithVSCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Wizard wizard = new Wizard();
            Ranger ranger = new Ranger();
            Rogue rogue = new Rogue();
            
            Console.WriteLine($"Hero's infos");
            Console.Write($"Name: ");

            string name = Console.ReadLine();
            knight.Name = name;

            Console.Write($"Level: ");

            int level = int.Parse(Console.ReadLine());
            knight.Level = level;

            Console.Write($"Type: ");

            string heroType = Console.ReadLine();
            knight.HeroType = heroType;

            Console.WriteLine($"");

            Console.WriteLine($"{knight.Attack()}");

            Console.WriteLine($"");

            Console.WriteLine($"{wizard.Attack(3)}");
        }
    }
}

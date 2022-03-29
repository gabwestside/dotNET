using System;

namespace DioExercise02
{
    public class Program
    {
        static void Main(string[] args)
        {
            int ano = 365, mes = 30;

            int dias = int.Parse(Console.ReadLine());
            int anos = dias / ano;

            dias = dias % ano;

            int meses = dias / mes;
            
            dias = dias % mes;
            
            Console.WriteLine($"{anos} ano(s)");
            Console.WriteLine($"{meses} mes(es)");
            Console.WriteLine($"{dias} dia(s)");
        }
    }
}
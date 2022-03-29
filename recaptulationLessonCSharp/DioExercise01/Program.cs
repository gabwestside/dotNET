using System;

namespace DioExercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            int quilometros = Int32.Parse(Console.ReadLine());
            int minutos = (quilometros * 60) / 30;
            Console.WriteLine(minutos + " minutos");
        }
    }
}
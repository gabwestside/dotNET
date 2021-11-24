using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // * Exemplo de casting explicito:
            double arara = 12.3;
            float banana;

            banana = (float)arara;

            // Console.WriteLine(b);

            // * Exemplo de mod

            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = (double) 10 / 8;

            // Console.WriteLine(n1 + "\n" + n2 + "\n" + n3 + "\n" + n4);

            // * Exemplo da formula de Baskhara

            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2) - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            //Console.WriteLine(delta);
            //Console.WriteLine(x1);
            //Console.WriteLine(x2);

            // * Exemplo de escrita no console:
            //string frase = Console.ReadLine();

            // Console.WriteLine("Bem vindo " + frase + ", você é foda meu irmão!");

            // * Exmplo de uso do split: 
            //string s = Console.ReadLine();
            //string[] v = s.Split(' ');
            //string x = v[0];
            //string y = v[1];
            //string z = v[2];

            //string[] bau = Console.ReadLine().Split(' ');
            //string f1 = bau[0];
            //string f2 = bau[1];

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            // Console.WriteLine("Objeto que tem no baú: " + f1 + " e " + f2);

            // * Exemplo de ler numero com o ReadLine()

            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Seu numero é " + numero);
         }
    }
}

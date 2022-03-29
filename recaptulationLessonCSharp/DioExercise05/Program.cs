using System;

namespace DioExercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            string checkPwd = "2002";

            string pwd = Console.ReadLine();

            while (pwd != checkPwd)
            {
                Console.WriteLine("Senha Invalida");

                pwd = Console.ReadLine();
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}

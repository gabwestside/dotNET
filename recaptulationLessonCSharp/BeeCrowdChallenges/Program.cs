using System;
using System.Globalization;

namespace BeeCrowdChallenges
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // Escreva um programa que leia o número de um funcionário, seu número de horas trabalhadas, 
            // o valor que recebe por hora e calcula o salário desse funcionário. A seguir, mostre o 
            // número e o salário do funcionário, com duas casas decimais.

            //int id, workedHours;
            //double valuePerHour, salary;

            //id = int.Parse(Console.ReadLine());
            //workedHours = int.Parse(Console.ReadLine());
            //valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //salary = workedHours * valuePerHour;
            
            //Console.WriteLine($"NUMBER = {id}");
            //Console.WriteLine($"SALARY = U$ {salary.ToString("F2", CultureInfo.InvariantCulture)}");


            // ------------------------------------------------------------------------------------ //


            // Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas 
            // efetuadas por ele no mês (em dinheiro). Sabendo que este vendedor ganha 15% de comissão 
            // sobre suas vendas efetuadas, informar o total a receber no final do mês, com duas casas 
            // decimais.
            
            string name;
            double salary, totalSales, total, discount = 0.15;

            name = Console.ReadLine();
            salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalSales = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            total = salary + (totalSales * discount);

            Console.WriteLine($"TOTAL = R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
            
            // ------------------------------------------------------------------------------------ //
        }
    }
}
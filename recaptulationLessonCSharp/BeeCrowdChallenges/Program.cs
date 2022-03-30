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

            // string name;
            // double salary, totalSales, total, discount = 0.15;

            // name = Console.ReadLine();
            // salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // totalSales = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // total = salary + (totalSales * discount);

            // Console.WriteLine($"TOTAL = R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");

            // ------------------------------------------------------------------------------------ //


            // Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido 
            // da mensagem “eh o maior”. Utilize a fórmula:

            // MaiorAB = (a+b+abs+(a-b)) / 2

            // Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, 
            // portanto é necessário para chegar no resultado esperado.

            // int firstNumber, secondNumber, thirdNumber;
            // double high1st2nd, isHigher;

            // string[] split = Console.ReadLine().Split(' ');            

            // firstNumber = int.Parse(split[0]);
            // secondNumber = int.Parse(split[1]);
            // thirdNumber = int.Parse(split[2]);

            // high1st2nd = (firstNumber + secondNumber + Math.Abs(firstNumber - secondNumber)) / 2;
            // isHigher = (high1st2nd + thirdNumber + Math.Abs(high1st2nd - thirdNumber)) / 2;

            // Console.WriteLine($"{isHigher} eh maior");

            // ------------------------------------------------------------------------------------ //

            // Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma 
            // fábrica, e informe-o expresso no formato horas:minutos:segundos.

            // int seconds, minutes, hours, minute = 60, hour = 3600;

            // seconds = int.Parse(Console.ReadLine());

            // hours = seconds / hour;

            // seconds = seconds % hour;

            // minutes = seconds / minute;

            // seconds = seconds % minute;

            // Console.WriteLine($"{hours}:{minutes}:{seconds}");

            // ------------------------------------------------------------------------------------ //

            // Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, 
            // p1(x1,y1) e p2(x2,y2) e calcule a distância entre eles, mostrando 4 casas decimais após a 
            // vírgula, segundo a fórmula:
            // Distancia = raiz((x2 - x1)² + (y2 - y1)²)

            // double x1, x2, y1, y2, dist;

            // string[] split1st = Console.ReadLine().Split(' ');   

            // string[] split2nd = Console.ReadLine().Split(' ');            

            // x1 = double.Parse(split1st[0], CultureInfo.InvariantCulture);

            // x2 = double.Parse(split2nd[0], CultureInfo.InvariantCulture);

            // y1 = double.Parse(split1st[1], CultureInfo.InvariantCulture);

            // y2 = double.Parse(split2nd[1], CultureInfo.InvariantCulture);

            // dist = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));

            // Console.WriteLine($"{dist.ToString("F4", CultureInfo.InvariantCulture)}");

            // ------------------------------------------------------------------------------------ //

            // Joaozinho quer calcular e mostrar a quantidade de litros de combustível gastos em uma 
            // viagem, ao utilizar um automóvel que faz 12 KM/L. Para isso, ele gostaria que você o 
            // auxiliasse através de um simples programa. Para efetuar o cálculo, deve-se fornecer o 
            // tempo gasto na viagem (em horas) e a velocidade média durante a mesma (em km/h). Assim, 
            // pode-se obter distância percorrida e, em seguida, calcular quantos litros seriam necessários. 
            // Mostre o valor com 3 casas decimais após o ponto.

            int travelTime, avgSpeed, gasNeeded = (12 / 1);
            double dist, qtdLitres;

            travelTime = int.Parse(Console.ReadLine());

            avgSpeed = int.Parse(Console.ReadLine());

            dist = travelTime * avgSpeed;

            qtdLitres = dist / gasNeeded;

            Console.WriteLine($"{qtdLitres.ToString("F3", CultureInfo.InvariantCulture)}");
            
            // ------------------------------------------------------------------------------------ //
        }
    }
}
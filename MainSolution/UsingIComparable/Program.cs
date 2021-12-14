using System;
using System.IO;
using System.Collections.Generic;
using UsingIComparable.Entities;

namespace UsingIComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\gabriel.moura.FITBANK\Documents\Gabs\tst.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}

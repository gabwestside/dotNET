using Exercicio03.Entities.Enums;
using System.Collections.Generic;

namespace Exercicio03.Entities
{
    public class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public List<HourContract> Contracts { get; private set; } = new List<HourContract>();

        public Worker ()
        {

        }
        
        public Worker(string name, WorkerLevel level, double baseSalary, Departament dept)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = dept;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int mouth)
        {
            double sum = BaseSalary;
            foreach(HourContract contract in Contracts)
            {
                if ( contract.Date.Year == year && contract.Date.Month == mouth)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
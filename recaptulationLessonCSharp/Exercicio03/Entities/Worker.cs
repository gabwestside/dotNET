using Exercicio03.Entities.Enums;
using System.Collections.Generic;

namespace Exercicio03.Entities
{
    public class Worker
    {
        public stirng Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<> Contracts { get; set; }

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
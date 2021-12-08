using System;
using System.Collections.Generic;
using System.Text;

namespace ProposedExercise01.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees)
            : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            return NumberOfEmployees;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPropostoContribuinte.Entities
{
    internal class Company : TaxPayer
    {
        public int EmployeesQuantity { get; set; }

        public Company(string name, double anualIncome, int employeesQuantity)
            : base(name, anualIncome)
        { 
            EmployeesQuantity = employeesQuantity;
        }

        public override double Tax()
        {
            if(EmployeesQuantity > 10)
            {
                return AnualIncome * 0.14;
            }

            return AnualIncome * 0.16;
        }
    }
}

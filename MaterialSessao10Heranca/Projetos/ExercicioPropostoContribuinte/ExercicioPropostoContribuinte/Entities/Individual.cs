using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPropostoContribuinte.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) 
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax = 0;
            if(AnualIncome >= 20000.00)
            {
                tax = AnualIncome * 0.25;
            }
            else
            {
                tax = AnualIncome * 0.15;
            }

            if (HealthExpenditures > 0)
            {
                tax -= HealthExpenditures * 0.5;
            }

            return tax;
        }
    }
}

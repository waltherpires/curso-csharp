﻿using System.Globalization;

using ExercicioPropostoContribuinte.Entities;

namespace ExercicioPropostoContribuinte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char payerType = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (payerType == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else if (payerType == 'c')
                {
                    Console.Write("Number of employees: ");
                    int employeesQuantity = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, anualIncome, employeesQuantity));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach (TaxPayer taxPayer in list) 
            {
                Console.WriteLine(
                    taxPayer.Name
                    + ": $ "
                    + taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture)
                );
            }

            double totalTaxes = 0;
            foreach (TaxPayer taxPayer in list)
            {
                totalTaxes += taxPayer.Tax();
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

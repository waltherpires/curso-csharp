using System.IO;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioFixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file path: ");
            string path = Console.ReadLine();
            List<Employee> employees = new List<Employee>();
            

            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string nome = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    employees.Add(new Employee(nome, email, salary));
                }
            }

            Console.Write("Enter salary: ");
            double salaryFilter = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var employeeEmails = employees
                .OrderByDescending(p => p.Email)
                .Where(p => p.Salary > salaryFilter)
                .Select(p => p.Email)
                ;

            Console.WriteLine();
            Console.WriteLine($"Email of people whose salary is more than {salaryFilter.ToString("F2", CultureInfo.InvariantCulture)}: ");
            foreach (String email in employeeEmails)
            {
                Console.WriteLine(email);
            }

            var sumM = employees
                .Where(p => p.Name[0] == 'M')
                .Select(p => p.Salary)
                .DefaultIfEmpty(0.0)
                .Sum();

            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sumM.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

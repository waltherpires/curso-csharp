using System.Collections.Generic;
using System.Globalization;

namespace ExercicioListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();
            Console.Write("Quantos empregados serao registrados? ");
            int registros = int.Parse(Console.ReadLine());

            for (int i = 0; i < registros; i++)
            {
                Console.WriteLine("Empregado #" + i);
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Salario: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employeeList.Add(new Employee(id, name, salary));
            }

            Console.WriteLine();
            Console.Write("Digite o id do empregado que vai ter o salario aumentado: ");
            int idPesquisa = int.Parse(Console.ReadLine());
            Employee empregadoAumento = employeeList.Find(x => x.Id == idPesquisa);
            if (empregadoAumento != null)
            {
                Console.Write("Digite a porcentagem de aumento: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                empregadoAumento.increaseSalary(porcentagem);

            } else
            {
                Console.WriteLine("Esse ID nao existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada de empregados: ");
            foreach(Employee obj in employeeList)
            {
                Console.WriteLine(obj);
            }
        }
    }
}

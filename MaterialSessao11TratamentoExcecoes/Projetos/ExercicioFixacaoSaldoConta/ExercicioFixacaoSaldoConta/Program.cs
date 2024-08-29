using System.Globalization;

using ExercicioFixacaoSaldoConta.Entities;
using ExercicioFixacaoSaldoConta.Entities.Exceptions;

namespace ExercicioFixacaoSaldoConta
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);   
            Account account = new Account(number, holder, balance, withdrawLimit);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double withdrawAmount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            try
            {
                account.Withdraw(withdrawAmount);
            }
            catch (DomainException e) {
                Console.WriteLine("Withdraw Error: " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Unknown error: " + e.Message);
            }

            Console.Write("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

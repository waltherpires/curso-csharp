using System;
using System.Globalization;

namespace ExercicioContaBancaria
{
    internal class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroConta, string titular, double depositoInicial) : this(numeroConta, titular)
        {
            Deposito(depositoInicial);
        }

        public ContaBancaria(int numeroConta, string titular)
        {
            Numero = numeroConta;
            Titular = titular;
        }

        public void Saque(double valor)
        {
            Saldo  -= valor + 5.0;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public override string ToString()
        {
            return "Conta " + Numero
            + ", Titular: " + Titular
            + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

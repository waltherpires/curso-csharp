using ExercicioFixacaoInterface.Entities;
using System;


namespace ExercicioFixacaoInterface.Services
{
    interface IPaymentService
    {
        public double PaymentFee(double amount);
        public double Interest(double amount, int months);

    }
}

using ExercicioFixacaoInterface.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoInterface.Services
{
    internal class ContractService
    {
        private IPaymentService _iPaymentService { get; set; }

        public ContractService(IPaymentService iPaymentService)
        {
            _iPaymentService = iPaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime installmentDate = contract.Date.AddMonths(i);
                double updatedtQUota = basicQuota + _iPaymentService.Interest(basicQuota, i);
                double fullQuota = updatedtQUota + _iPaymentService.PaymentFee(updatedtQUota);

                contract.AddInstallment(new Installment(installmentDate, fullQuota));
            }
            
        }
    }
}

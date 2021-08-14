using ExercicioFixacao.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao.Services
{
    class InstallmentService
    {
        public double InitialValue { get; set; }
        public int QtdInstallment { get; set; }
        private ITax _tax;

        public InstallmentService(double initialValue, int qtdInstallment, ITax tax)
        {
            InitialValue = initialValue;
            QtdInstallment = qtdInstallment;
            _tax = tax;
        }

        public void ProcessInstallment(Contrato contrato)
        {
            for(int i = 0; i < QtdInstallment; i++)
            {
                Installment ins = new(contrato.Date.AddMonths(i + 1), _tax.Tax((i + 1), (InitialValue/QtdInstallment)));
                contrato.Installments.Add(ins);
            }

            foreach(Installment inst in contrato.Installments)
            {
                contrato.TotalValue += inst.Amount;
            }
        }
    }
}

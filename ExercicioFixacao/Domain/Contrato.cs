using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao.Domain
{
    public class Contrato
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; } = new();

        public Contrato(int number, DateTime date)
        {
            Number = number;
            Date = date;
        }

        public void GetTotalValue()
        {
            foreach(Installment amount in Installments)
            {
                TotalValue += amount.Amount;
            }
        }
    }
}

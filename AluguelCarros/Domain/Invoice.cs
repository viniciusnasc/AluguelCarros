using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarros.Domain
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
        public double TotalPayment { get { return BasicPayment + Tax; } }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public override string ToString()
        {
            return "BASIC PAYMENT: " + BasicPayment.ToString("F2") + 
                   "\nTAX: " + Tax.ToString("F2") +
                   "\nTOTAL PAYMENT: " + TotalPayment.ToString("F2");
        }

    }
}

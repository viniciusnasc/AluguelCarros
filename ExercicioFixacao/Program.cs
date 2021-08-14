using ExercicioFixacao.Domain;
using ExercicioFixacao.Services;
using System;
using System.Diagnostics.Contracts;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Contrato contrato = new(number, date);

            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            int numberInstallments = int.Parse(Console.ReadLine());

            InstallmentService ins = new(value, numberInstallments, new PaypalService());
            ins.ProcessInstallment(contrato);

            Console.WriteLine("Installments: ");

            foreach(Installment i in contrato.Installments)
            {
                Console.WriteLine(i);
            }
        }
    }
}

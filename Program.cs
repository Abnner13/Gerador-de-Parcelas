using System;
using System.Globalization;
using ProjectPayment.Entities;
using ProjectPayment.Services;

namespace ProjectPayment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int numberContract = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateTime startContract = DateTime.Parse(Console.ReadLine());

            Console.Write("Contract value: ");
            double valueContract = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter number of installments: ");
            int numberInstal = int.Parse(Console.ReadLine());

            Contract contract = new Contract(numberContract, startContract, valueContract);
            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract, numberInstal);

            Console.WriteLine("Installments: ");
            Console.WriteLine();
            foreach (Parcelas parcelas in contract.Parcela)
            {
                System.Console.WriteLine(parcelas);
            }


        }
    }
}

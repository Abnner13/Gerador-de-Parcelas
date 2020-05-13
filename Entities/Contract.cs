using System;
using System.Collections.Generic;

namespace ProjectPayment.Entities
{
    class Contract
    {
        public int NumeroContrato { get; set; }
        public DateTime StartContrato { get; set; }
        public double TotalValue { get; set; }
        public List<Parcelas> Parcela { get; set; } = new List<Parcelas>();

        public Contract(int numberContract, DateTime startContract, double totalValue)
        {
            NumeroContrato = numberContract;
            StartContrato = startContract;
            TotalValue = totalValue;
            Parcela = new List<Parcelas>();
        }

        public void AddParcelas(Parcelas parcelas)
        {
            Parcela.Add(parcelas);
        }


    }
}

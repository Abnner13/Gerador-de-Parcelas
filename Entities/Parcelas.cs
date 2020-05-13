using System;
using System.Globalization;

namespace ProjectPayment.Entities
{
    class Parcelas
    {
        public Contract contract { get; set; }
        public DateTime DatePayment { get; set; }
        public double ValueParcela { get; set; }

        public Parcelas(DateTime datePayment, double valueParcela)
        {
            DatePayment = datePayment;
            ValueParcela = valueParcela;
        }


        public override string ToString()
        {
            return DatePayment.ToString("dd/MM/yyyy")
            + " - " + ValueParcela.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

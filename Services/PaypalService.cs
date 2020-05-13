namespace ProjectPayment.Services
{
    class PaypalService : OnlinePaymenttService
    {
        private const double juros = 0.02;
        private const double interest = 0.01;

        public double Interest(double amount, int months)
        {
            return amount * interest * months;
        }

        public double Juros(double amount)
        {
            return amount * juros;
        }
    }
}

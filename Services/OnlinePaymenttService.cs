namespace ProjectPayment.Services
{
    public interface OnlinePaymenttService
    {
        public double Juros(double amount);
        public double Interest(double amount, int months);
    }
}

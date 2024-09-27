namespace Contracts.Services
{
    class PaypalPaymentService : IOnlinePaymentService
    {
        public double interest(double amount, int month)
        {
            return amount * (0.01 * month);
        }

        public double paymentFee(double amount)
        {
            return amount * 0.02;
        }
    }
}

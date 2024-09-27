namespace Contracts.Services
{
    interface IOnlinePaymentService
    {
        public double interest(double amount, int month);
        public double paymentFee(double amount);
    }
}

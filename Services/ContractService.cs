using Contracts.Entities;

namespace Contracts.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void processContract(Contract contract, int months)
        {
            List<Portion> portions = new List<Portion>();
            for (int i = 0; i < months; i++)
            {
                double portionBaseValue = contract.value / months;
                double interest = _onlinePaymentService.interest(portionBaseValue, i + 1);
                double paymentFee = _onlinePaymentService.paymentFee(portionBaseValue + interest);

                double portionFinalValue = portionBaseValue + interest + paymentFee;

                DateTime paymentDue = contract.contractDate.AddMonths(i + 1);
                Portion currentPortion = new Portion(paymentDue, portionFinalValue);

                portions.Add(currentPortion);
            }

            contract.portions = portions;
        }
    }
}

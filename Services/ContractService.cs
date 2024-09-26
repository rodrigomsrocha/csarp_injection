using Contracts.Entities;

namespace Contracts.Services
{
    class ContractService
    {
        public double value { get; set; }
        public int months { get; set; }

        public void processContract(Contract contract)
        {
            for (int i = 0; i < months; i++)
            {

            }
        }
    }
}

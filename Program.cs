using System.Globalization;
using Contracts.Entities;
using Contracts.Services;

namespace Contracts
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite os dados do ontrato");
            Console.Write("Número do contrato: ");
            int contractNumber = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Data do contrato (dd/MM/yyyy): ");
            DateTime contractDate;
            DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out contractDate);

            Console.Write("Valor do contrato: ");
            double contractValue = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);

            Contract contract = new Contract(contractNumber, contractDate, contractValue);

            Console.Write("Digite o número de parcelas: ");
            int portions = int.Parse(Console.ReadLine() ?? "0");

            ContractService contractService = new ContractService(new PaypalPaymentService());
            contractService.processContract(contract, portions);

            Console.WriteLine();
            Console.WriteLine("Parcelas");
            foreach (Portion portion in contract.portions)
            {
                Console.WriteLine(portion);
            }
        }
    }
}

using System.Globalization;
using Contracts.Entities;

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
        }
    }
}

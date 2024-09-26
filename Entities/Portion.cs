using System.Globalization;

namespace Contracts.Entities
{
    class Portion
    {
        public DateTime paymentDue { get; set; }
        public double value { get; set; }

        public Portion(DateTime paymentDue, double value)
        {
            this.paymentDue = paymentDue;
            this.value = value;
        }

        public override string ToString()
        {
            return
            paymentDue.ToString("dd/MM/yyyy")
            + " - "
            + value.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

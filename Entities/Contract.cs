namespace Contracts.Entities
{
    class Contract
    {
        public int contractNumber { get; set; }
        public DateTime contractDate;
        public double value;
        public List<Portion> portions { get; set; } = new List<Portion>();

        public Contract(int contractNumber, DateTime contractDate, double value)
        {
            this.contractNumber = contractNumber;
            this.contractDate = contractDate;
            this.value = value;
        }
    }
}

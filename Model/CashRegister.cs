internal partial class Program
{
    public class CashRegister
    {
        public double TotalCash { get; set; }

        public CashRegister(double initialCash)
        {
            TotalCash = initialCash;
        }

    }
}
namespace Balances.Model
{
    public class Available
    {
        public decimal Amount { get; set; }

        public string CreditDebitIndicator { get; set; }

        public object CreditLines { get; set; }
    }
}
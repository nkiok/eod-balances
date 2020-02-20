namespace Balances.Model
{
    public class Current
    {
        public decimal Amount { get; set; }

        public string CreditDebitIndicator { get; set; }

        public object CreditLines { get; set; }
    }
}
using System.Collections.Generic;

namespace Balances.Model
{
    public class Account
    {
        public string AccountId { get; set; }

        public string CurrencyCode { get; set; }

        public string DisplayName { get; set; }

        public string AccountType { get; set; }

        public string AccountSubType { get; set; }

        public Identifiers Identifiers { get; set; }

        public IEnumerable<Party> Parties { get; set; }

        public IEnumerable<StandingOrder> StandingOrders { get; set; }
        
        public IEnumerable<DirectDebit> DirectDebits { get; set; }

        public Balances Balances { get; set; }

        public IEnumerable<Transaction> Transactions { get; set; }
    }
}
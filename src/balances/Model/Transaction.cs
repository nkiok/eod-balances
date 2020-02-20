using System;

namespace Balances.Model
{
    public class Transaction
    {
        public string Description { get; set; }

        public decimal Amount { get; set; }

        public string CreditDebitIndicator { get; set; }

        public string Status { get; set; }

        public DateTimeOffset BookingDate { get; set; }

        public object MerchantDetails { get; set; }
    }
}
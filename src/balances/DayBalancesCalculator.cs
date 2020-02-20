using System;
using System.Collections.Generic;
using System.Linq;
using Balances.Model;

namespace Balances
{
    public class DayBalancesCalculator : IBalancesCalculator<AccountsDto, IEnumerable<OutputDto>>
    {
        private const string CreditIndicator = "Credit";
        private const string DebitIndicator = "Debit";

        public IEnumerable<OutputDto> Calculate(AccountsDto input)
        {
            return input.Accounts.Select(account => 
                    account.Transactions.Where(t => t.BookingDate.Date <= input.RequestDateTime.Date)
                        .GroupBy(t => t.BookingDate.ToString("yyyy-MM-dd"))
                        .Select(g => new DayTotals()
                        {
                            Date = g.Key, 
                            TotalCredits = g.Where(t => TransactionIndicatorMatches(t, CreditIndicator)).Sum(t => t.Amount), 
                            TotalDebits = g.Where(t => TransactionIndicatorMatches(t, DebitIndicator)).Sum(t => t.Amount),
                        })
                        .OrderBy(t => t.Date)
                    .ToList())
                .Select(dayTotals => new OutputDto()
                {
                    TotalCredits = dayTotals.Sum(g => g.TotalCredits), 
                    TotalDebits = dayTotals.Sum(g => g.TotalDebits), 
                    EndOfDayBalances = dayTotals.Select((g, i) => new DayBalance()
                    {
                        Date = g.Date, 
                        Balance = dayTotals.Take(i + 1).Sum(t => t.TotalCredits) - dayTotals.Take(i + 1).Sum(t => t.TotalDebits)
                    })
                });
        }

        private static bool TransactionIndicatorMatches(Transaction transaction, string indicator)
            => transaction.CreditDebitIndicator.Equals(indicator, StringComparison.OrdinalIgnoreCase);
    }
}

using System.Collections.Generic;

namespace Balances.Model
{
    public class OutputDto
    {
        public decimal TotalCredits { get; set; }

        public decimal TotalDebits { get; set; }
        
        public IEnumerable<DayBalance> EndOfDayBalances { get; set; }
    }
}

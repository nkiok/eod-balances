﻿namespace Balances.Model
{
    public class DayTotals
    {
        public string Date { get; set; }

        public decimal TotalCredits { get; set; }

        public decimal TotalDebits { get; set; }
    }
}
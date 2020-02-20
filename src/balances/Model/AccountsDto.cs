using System;
using System.Collections.Generic;

namespace Balances.Model
{
    public class AccountsDto
    {
        public string BrandName { get; set; }

        public string DataSourceName { get; set; }

        public string DataSourceType { get; set; }

        public DateTimeOffset RequestDateTime { get; set; }

        public IEnumerable<Account> Accounts { get; set; }
    }
}
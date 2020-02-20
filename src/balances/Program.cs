using System;
using System.IO;
using System.Text.Json;
using Balances.Model;

namespace Balances
{
    class Program
    {
        static void Main(string[] args)
        {
            var pathToFile = args.Length == 1
                ? args[0]
                : Path.Combine(Directory.GetCurrentDirectory(), @"input-data", @"Account.json");

            var dataProvider = new DataFromFileProvider<AccountsDto>(pathToFile);

            var data = dataProvider.GetData();

            var calculator = new DayBalancesCalculator();

            var result = calculator.Calculate(data);

            Console.WriteLine(JsonSerializer.Serialize(result, new JsonSerializerOptions() { WriteIndented = true }));
        }
    }
}

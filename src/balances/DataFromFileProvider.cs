using System.IO;
using System.Text.Json;

namespace Balances
{
    public class DataFromFileProvider<T> : IDataProvider<T>
    {
        private readonly string _pathToFile;

        public DataFromFileProvider(string pathToFile)
        {
            _pathToFile = pathToFile;
        }

        public T GetData()
        {
            var input = File.ReadAllText(_pathToFile);

            var data = JsonSerializer.Deserialize<T>(input, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            return data;
        }
    }
}

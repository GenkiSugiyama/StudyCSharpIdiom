using System.Collections.Generic;

namespace SalesCalculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var counter = new SalesCounter("../../../sample.csv");
            IDictionary<string, int> amountPerStores = counter.GetPerStoreSales();

            foreach (KeyValuePair<string, int> obj in amountPerStores)
            {
                Console.WriteLine($"{obj.Key} の売り上げは¥{obj.Value}");
            }
        }
    }
}

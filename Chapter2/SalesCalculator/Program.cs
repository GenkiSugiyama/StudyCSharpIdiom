using System.Collections.Generic;

namespace SalesCalculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var counter = new SalesCounter("../../../../sample.csv");
            IDictionary<string, int> amountPerStores = counter.GetPerStoreSales();

            foreach (KeyValuePair<string, int> obj in amountPerStores)
            {
                Console.WriteLine("店舗ごとの売上");
                Console.WriteLine($"{obj.Key} の売り上げは¥{obj.Value}");
            }

            IDictionary<string, int> amountPerCategories = counter.GetPerCategorySales();
            foreach (KeyValuePair<string, int> obj in amountPerCategories)
            {
                Console.WriteLine("カテゴリごとの売り上げ");
                Console.WriteLine($"{obj.Key}の売り上げは \\{obj.Value}");
            }
        }

        // DictionaryはKeyValuePair型の集まり！
    }
}

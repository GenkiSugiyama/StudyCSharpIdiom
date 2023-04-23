using System.Collections.Generic;

namespace SalesCalculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SalesCounter counter = new SalesCounter(ReadSales("../../../sample.csv"));
            Dictionary<string, int> amountPerStores = counter.GetPerStoreSales();

            foreach (KeyValuePair<string, int> obj in amountPerStores)
            {
                Console.WriteLine($"{obj.Key} の売り上げは¥{obj.Value}");
            }
        }

        static List<Sale> ReadSales(string filePath)
        {
            List<Sale> sales = new List<Sale>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                string[] items = line.Split(',');
                Sale sale = new Sale
                {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);
            }

            return sales;
        }
    }
}

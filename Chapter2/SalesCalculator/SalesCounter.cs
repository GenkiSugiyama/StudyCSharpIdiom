using System;
using System.Collections.Generic;

namespace SalesCalculator
{
    //売り上げ集計クラス
    public class SalesCounter
    {
        private IEnumerable<Sale> _sales;

        public SalesCounter(string filePath)
        {
            this._sales = ReadSales(filePath);
        }

        //戻り値をインターフェースにしておくことでこのメソッド内の修正で変数の型変更が必要になったとしても
        //外部に影響が出にくくすることができる
        //パブリックなメソッドが返す値は具体的なクラスではなく可能であればインターフェースにしたほうが変更に強そう
        public IDictionary<string, int> GetPerStoreSales()
        {
            var dict = new Dictionary<string, int>();
            foreach (var sale in _sales)
            {
                if (dict.ContainsKey(sale.ShopName))
                {
                    dict[sale.ShopName] += sale.Amount;
                }
                else
                {
                    dict[sale.ShopName] = sale.Amount;
                }
            }

            return dict;
        }

        public IDictionary<string, int> GetPerCategorySales()
        {
            var dict = new Dictionary<string, int>();
            foreach (var sale in _sales)
            {
                if (dict.ContainsKey(sale.ProductCategory))
                {
                    dict[sale.ProductCategory] += sale.Amount;
                }
                else
                {
                    dict[sale.ProductCategory] = sale.Amount;
                }
            }

            return dict;
        }

        private static IEnumerable<Sale> ReadSales(string filePath)
        {
            var sales = new List<Sale>();
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


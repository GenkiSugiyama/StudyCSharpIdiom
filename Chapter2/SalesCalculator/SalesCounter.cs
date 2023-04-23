using System;
using System.Collections.Generic;

namespace SalesCalculator
{
    //売り上げ集計クラス
    public class SalesCounter
    {
        private List<Sale> _sales;

        public SalesCounter(List<Sale> sales)
        {
            this._sales = sales;
        }

        public Dictionary<string, int> GetPerStoreSales()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
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
    }
}


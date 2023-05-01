using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLamda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            var result1 = numbers.Exists(n => n % 8 == 0 || n % 9 == 0);
            Console.WriteLine(result1);


            numbers.ForEach(n => Console.WriteLine(n / 2.0));

            var results3 = numbers.Where(n => n >= 50);
            Console.WriteLine(results3);

            var result4 = numbers.Select(n => n * 2).ToList();
            Console.WriteLine(result4);
        }
    }
}

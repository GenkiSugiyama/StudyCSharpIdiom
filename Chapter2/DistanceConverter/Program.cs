using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //プログラム実行時にコマンドライン引数を受け取って処理を分岐させる
            if (args.Length >= 1 && args[0] == "-tom")
            {
                for (int ft = 1; ft <= 10; ft++)
                {
                    double meter = FeetToMeter(ft);
                    Console.WriteLine($"{ft} ft = {meter:0.0000} m");
                }
            }
            else
            {
                for (int meter = 1; meter <= 10; meter++)
                {
                    double ft = MeterToFeet(meter);
                    Console.WriteLine($"{meter} m = {ft:0.0000} ft");
                }
            }

        }

        //計算ロジックを独立させる
        static double FeetToMeter(int feet)
        {
            return feet * 0.3048;
        }

        static double MeterToFeet(int meter)
        {
            return meter / 0.3048;
        }
    }
}

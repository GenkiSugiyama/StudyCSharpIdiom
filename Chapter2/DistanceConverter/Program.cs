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
                PrintFeetToMeterList(1, 10);
            }
            else
            {
                PrintMeterToFeetList(1, 15);
            }

        }

        //Main関数内メソッドを独立させる
        static void PrintFeetToMeterList(int start, int stop)
        {
            for (int ft = start; ft <= stop; ft++)
            {
                double meter = FeetConverter.ToMeter(ft);
                Console.WriteLine($"{ft} ft = {meter:0.0000} m");
            }
        }

        static void PrintMeterToFeetList(int start, int stop)
        {
            for (int meter = start; meter <= stop; meter++)
            {
                double ft = FeetConverter.FromMeter(meter);
                Console.WriteLine($"{meter} m = {ft:0.0000} ft");
            }
        }
    }
}

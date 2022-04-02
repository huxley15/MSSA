using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod9Demo4
{
    class Program
    {
        private const double tipRate = 0.18;
        public static void Main(string[] args)
        {
            double billTotal;
            if (args.Length == 0 || !Double.TryParse(args[0], out billTotal))
            {
                Console.WriteLine("usage: TIPCALC total");
                return;
            }
            double tip = billTotal * tipRate;
            Console.WriteLine();
            Console.WriteLine($"Bill total:\t{billTotal,8:c}");
            Console.WriteLine($"Tip total/rate:\t{tip,8:c} ({tipRate:p1})");
            Console.WriteLine(("").PadRight(24, '-'));
            Console.WriteLine($"Grand total:\t{billTotal + tip,8:c}");
        }
        //static void Main(string[] args)
        //{
        //    //Format specifiers
        //    Console.WriteLine("(C) Currency:.....{0:C}", 50);
        //    Console.WriteLine("(P) Percentage:.....{0:P}", 50);
        //    Console.WriteLine("(P) Percentage:.....{0:p3}", 50);
        //    Console.WriteLine("(X) Hexadecimal:.....{0:X}", 50);
        //    Console.ReadLine();
        //}
    }
}

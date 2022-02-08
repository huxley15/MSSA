using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("The first 10 natural numbers are:");
            for (int i = 1; i < 11; i++)
            {
                sum = sum + i;
                Console.WriteLine($"{i}");
            }
            Console.WriteLine($"The Sum is: {sum}");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers:");
            int num1 = Int32.Parse(Console.ReadLine());
            int num2 = Int32.Parse(Console.ReadLine());
            if(num1==num2)
            {
                Console.WriteLine($"{num1} and {num2} are equal");
            }
            else if(num1 < num2)
            {
                Console.WriteLine($"{num1} is less than {num2}");
            }
            else if(num1 > num2)
            {
                Console.WriteLine($"{num1} is greater than {num2}");
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0,1,1,2,3,5,8,13,21...

            Console.WriteLine("Enter the number of elements in series:");
            int num = Int32.Parse(Console.ReadLine());
            Fibonacci(num);
            Console.ReadLine();
        }
        static void Fibonacci(int len)
        {
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }
    }
}

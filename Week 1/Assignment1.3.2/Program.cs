using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num;
            Console.WriteLine("Please enter the size of the array:");
            int size = Int32.Parse(Console.ReadLine());
            num = new int[size];
            Console.WriteLine($"Please enter {size} numbers");
            for(int i=0; i<num.Length;i++)
            {
                Console.Write($"Element {i}:");
                num[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("The values stored in the array are:");
            for(int t=0;t<num.Length;t++)
            {
                Console.Write(num[t] + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("The values stored into the array in reverse are:");

            Array.Reverse(num);
            for(int i=0;i<num.Length;i++)
            {
                Console.Write(num[i] + " ");
            }
            Console.ReadLine();
        }
    }
}

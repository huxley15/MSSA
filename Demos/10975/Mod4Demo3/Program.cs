using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 100, 23, 150, 2, 12 };
            BubbleSort(numbers);
            Console.WriteLine("Sorted list:");
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }

        static void BubbleSort(int []data)
        {
            try
            {
                int temp = 0;
                for (int i = 1; i <= data.Length; i++)
                {
                    for (int j = 0; j < (data.Length - 1); j++)
                    {
                        if (data[j + 1] < data[j]) //if next index location is less than current index location
                        {
                            temp = data[j];
                            data[j] = data[j + 1];
                            data[j + 1] = temp;
                            //swap
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}

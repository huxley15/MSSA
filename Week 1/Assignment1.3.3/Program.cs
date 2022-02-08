using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 15, 222, 101, 404, 88 };
            BubbleSort(nums);
            Console.WriteLine("Bubble sorted list ascending:");
            foreach(int i in nums)
            {
                Console.WriteLine(i);
            }
            BubbleSortDesc(nums);
            Console.WriteLine("Bubble sorted list descending:");
            foreach(int i in nums)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        static void BubbleSort(int[] data)
        {
            int temp = 0;
            for (int i = 1; i<= data.Length; i++)
            {
                for(int j=0;j<(data.Length - 1); j++)
                {
                    if (data[j + 1] < data[j])
                    {
                        temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }
        }
        static void BubbleSortDesc(int[] data)
        {
            int temp = 0;
            for (int i = 1; i <= data.Length; i++)
            {
                for (int j = 0; j < (data.Length - 1); j++)
                {
                    if (data[j + 1] > data[j])
                    {
                        temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }
        }
    }
}

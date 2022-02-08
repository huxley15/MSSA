using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignent1._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            char choice = 'y';
            while(choice =='y' || choice =='Y')
            {
                CallMenu();
                Console.WriteLine("Do you want to continue? Y/N");
                choice = Convert.ToChar(Console.ReadLine());
            }
            Console.ReadLine();
        }

        static void CallMenu()
        {
            Console.WriteLine("Which operation would you like to perform today? Enter the corresponding number");
            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Subtraction");
            Console.WriteLine("3: Multiplication");
            int choice = Int32.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Addition();
                    break;
                case 2:
                    Subtraction();
                    break;
                case 3:
                    Multiplication();
                    break;
                default:
                    break;

            }
        }
        static void Addition()
        {
            Console.WriteLine("Enter 2 numbers:");
            int num1, num2;
            num1 = Int32.Parse(Console.ReadLine());
            num2 = Int32.Parse(Console.ReadLine());
            int result = num1 + num2;
            Console.WriteLine("Result is " + result);
        }
        static void Subtraction()
        {
            Console.WriteLine("Enter 2 numbers:");
            int num1, num2;
            num1 = Int32.Parse(Console.ReadLine());
            num2 = Int32.Parse(Console.ReadLine());
            int result = num1 - num2;
            Console.WriteLine("Result is " + result);
        }
        static void Multiplication()
        {
            Console.WriteLine("Enter 2 numbers:");
            int num1, num2;
            num1 = Int32.Parse(Console.ReadLine());
            num2 = Int32.Parse(Console.ReadLine());
            int result = num1 * num2;
            Console.WriteLine("Result is " + result);
        }
    }
}

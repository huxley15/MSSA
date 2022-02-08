using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            char choice = 'y';
            while(choice=='y'||choice=='Y')
            {
                CallMenu();
                Console.WriteLine("Do you want to continue? Y/N");
                choice = Convert.ToChar(Console.ReadLine());
            }
            Console.ReadLine();
        }

        static void CallMenu()
        {
            Console.WriteLine("Which shape would you like to calculate the area of? Please enter the corresponding number");
            Console.WriteLine("1: Triangle");
            Console.WriteLine("2: Square");
            Console.WriteLine("3: Rectangle");
            int choice = Int32.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Triangle();
                    break;
                case 2:
                    Square();
                    break;
                case 3:
                    Rectangle();
                    break;
                default:
                    break;
            }
        }
        static void Triangle()
            {
                Console.WriteLine("Enter the base and height:");
                float num1, num2;
                num1 = float.Parse(Console.ReadLine());
                num2 = float.Parse(Console.ReadLine());
                float result = 0.5f * num1 * num2;
                Console.WriteLine("Result is " + result);
            }
        static void Square()
            {
                Console.WriteLine("Enter the length:");
                int num1, num2;
                num1 = Int32.Parse(Console.ReadLine());
                int result = num1 * num1;
                Console.WriteLine("Result is " + result);
            }
        static void Rectangle()
            {
                Console.WriteLine("Enter the length and height:");
                int num1, num2;
                num1 = Int32.Parse(Console.ReadLine());
                num2 = Int32.Parse(Console.ReadLine());
                int result = num1 * num2;
                Console.WriteLine("Result is " + result);
            }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Demo1
{
    class Program
    {
        static void PrintName(string name)
        {
            Console.WriteLine($"Hello {name}"); //$ causes everything written to be considered for part of string

        }
        static void Main(string[] args) // entry point 
        {
            //#region declarations
            //int i; // integer is faster, temp allocation for full loop
            //i = 20;
            //short j; // better for storing data within structure of class
            //j = 20;
            //long k = 5645454555;
            //bool answer = true;
            //const float rateofInterest = 3.4F; // const keyword is constant, cannot reassign value
            //#endregion

            /* #region variabledeclarations
            string name = "xyz";
            char c = 'N';
            #endregion */

            Console.WriteLine("Enter 2 numbers:");
            Console.WriteLine("Enter num1:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int result= addNumbers(number1, number2);

            Console.WriteLine($"The result is {result}");

            PrintName("World");
            Console.ReadLine();

        }


        //function definition access specifier, return type, name(parameters - specify data type and name)
        static int addNumbers(int num1,int num2)
        {
            //logic
            return num1 + num2;

        }
    }
}

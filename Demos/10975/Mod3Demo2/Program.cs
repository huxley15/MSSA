using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number:");
            int num1 = Int32.Parse(Console.ReadLine());
            int num2 = Int32.Parse(Console.ReadLine());
            if (num1 > 100)
            {
                if (num1 > 300)
                {
                    Console.WriteLine("Greater than 300");
                }
                else if (num1 > 200)
                {
                    Console.WriteLine("Greater than 200");
                }
                else if (num1 > 150)
                {
                    Console.WriteLine("Greater than 150");
                }
                else
                {
                    Console.WriteLine("Number is between 100 and 150");
                }
            }
            if((num1 == 100) && (num2==100)) //logical AND
                {

                }
            if ((num1 == 100) || (num2 == 100)) //logical OR
                {

                }
            if (num1 >= 100)
                {

                }
            if(num1 <= 100)
                {

                }
            if(num1!=40) //not equal to
            else
                {

                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.BackgroundColor = ConsoleColor.White;
            float age;
            string firstName;
            string address;

            // Console.WriteLine("float max value : {0}", float.MaxValue);

            Console.WriteLine("Please enter your name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Please enter your age:");
            age =Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Please enter your street address:");
            address = Console.ReadLine();
            // Console.ReadKey();
            // Console.ReadLine();

            Console.WriteLine("Your information:");
            Console.WriteLine("Name is {0} , age is {1} , address is {2}", firstName, age, address);
            Console.ReadLine();
        }
    }
}

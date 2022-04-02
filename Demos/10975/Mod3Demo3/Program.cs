using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            string favColor;
            Console.WriteLine("Enter your favorite color:");
            favColor = Console.ReadLine();

            // Console.CapsLock 
            // favColor.ToUpper
            // favColor.ToLower
            switch(favColor.ToLower())
            {
                case "Red":
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Red it is!");
                    break;
                case "Green":
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Green it is!");
                    break;
                case "Purple":
                case "purple":
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Purple it is!");
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Default color");
                    break;
            }

            Console.ReadLine();

            Console.WriteLine("Enter 5 numbers:");
            int num;
            int sum = 0;
            for (int i = 0; i < 5; i++) //initialization, condition check, increment or decrement
            {
                num = Int32.Parse(Console.ReadLine());
                sum = sum + num;
            }
            Console.WriteLine($"result is {sum}");
            Console.ReadLine();
        }
    }
}

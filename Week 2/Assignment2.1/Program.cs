using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            char choice = 'y';
            while (choice == 'y' || choice == 'Y')
            {
                callMenu();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Would you like to do it again? Y/N");
                choice = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Have a great day! Press enter to exit.");
            Console.ReadLine();
        }
        static void callMenu()
        {
            Console.WriteLine("Which shape would you like to work with? Please enter circle or square");
            string choice = Console.ReadLine();
            switch (choice.ToLower())
            {
                case "circle":
                    Circle circle1 = new Circle();
                    Random random = new Random();
                    circle1.Id = random.Next(1, 100);
                    Console.WriteLine("The ID for your circle is " + circle1.Id);
                    Console.WriteLine("Would you like your circle to be blue, green, purple, or red?");
                    circle1.Color = Console.ReadLine();
                    switch (circle1.Color.ToLower())
                    {
                        case "blue":
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Blue as the California sky");
                            break;
                        case "green":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Green as grass");
                            break;
                        case "purple":
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("Purple is my favorite color too! :)");
                            break;
                        case "red":
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Red like the color of my face when I have to admit to Deepali that I am very confused at times :(");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("I guess you're stuck with boring old white!");
                            break;
                    }

                    Console.WriteLine("Please enter the radius of your circle:");
                    circle1.Radius = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("The area of your circle is " + circle1.CalculateArea());
                    break;
                case "square":
                    Square square1 = new Square();
                    Random random1 = new Random();
                    square1.Id = random1.Next(1, 100);
                    Console.WriteLine("The ID for your square is " + square1.Id);
                    Console.WriteLine("Would you like your square to be blue, green, purple, or red?");
                    square1.Color = Console.ReadLine();
                    switch (square1.Color.ToLower())
                    {
                        case "blue":
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Blue like the Hawaiian waters");
                            break;
                        case "green":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Green like the grass that I miss so much during winter");
                            break;
                        case "red":
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Red like ripe pomegranates!");
                            break;
                        case "purple":
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("Purple is the color of royalty");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("White is simple and clean");
                            break;
                    }
                    Console.WriteLine("Please enter the length of your square's sides");
                    square1.Length = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("The area of your square is " + square1.CalculateArea());
                    break;
                default:
                    Console.WriteLine("Please enter a valid shape from either circle or square.");
                    break;
            }
        }
    }
}

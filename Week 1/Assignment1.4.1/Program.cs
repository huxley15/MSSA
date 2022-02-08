using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(); //create a new instance of point 
            Console.WriteLine("Please enter 2 values for coordinates, beginning with x and then with y:");
            try
            {
                p1.x = Int32.Parse(Console.ReadLine()); //receive coordinate inputs from user
                p1.y = Int32.Parse(Console.ReadLine());
                Console.WriteLine($"P1 coordinates are ({p1.x},{p1.y})"); //to show user their inputs in coordinate form for clarity
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Point p2 = new Point();
            Console.WriteLine("Now please enter 2 values for a second set of coordinates, beginning with x and then with y:");
            try
            {
                p2.x = Int32.Parse(Console.ReadLine());
                p2.y = Int32.Parse(Console.ReadLine());
                Console.WriteLine($"P2 coordinates are ({p2.x},{p2.y})");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            if ((p1.x) > (p2.x)) 
            {
                Console.WriteLine("P1 is to the right of P2");
            }
            else if ((p1.x) < (p2.x))
            {
                Console.WriteLine("P1 is to the left of P2");
            }
            else if ((p1.x) == (p2.x))
            {
                Console.WriteLine("P1 and P2 are on the same x axis");
            }
            
          
            Console.ReadLine();
        }
    }
}

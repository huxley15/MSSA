using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._1
{
    abstract class Shape
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public abstract double CalculateArea();
        
    }
    class Circle : Shape
    {
        public int Radius { get; set; }
        public override double CalculateArea()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        }
        public void DisplayCircleInfo()
        {
            Console.WriteLine($"Circle information: ID = {this.Id}, Color = {this.Color}");
        }
    }
    class Square : Shape
    {
        public int Length { get; set; }
        public override double CalculateArea()
        {
            return Math.Pow(Length, 2);
        }
    }
}

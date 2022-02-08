using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._1
{
    class Being
    {
        public int Weight { get; set; }
        public char Gender { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public virtual double CalculateHeight()
        {
            return this.Weight * this.Age;
        }
    }
    class Human : Being
    {
        public string Ego { get; set; }
        public string Purpose { get; set; }
    }
    class Dwarf : Human
    {
        public int NumberOfGems { get; set; }
        public string favoriteAle { get; set; }
        public override double CalculateHeight()
        {
            return (base.CalculateHeight())/2;
        }
    }
    class Elf : Human
    {
        public string MagicSpecialization { get; set; }
        public override double CalculateHeight()
        {
            return (base.CalculateHeight()) * 1.5;
        }
    }
}

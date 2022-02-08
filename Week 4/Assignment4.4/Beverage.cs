using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._4
{
    enum DrinkSize
    {
        Small,
        Medium,
        Large
    }
    enum PreferredTemp
    {
        Steaming,
        Warm,
        Iced
    }
    enum CoffeeTypes
    {
        Americano,
        Cappuccino,
        Espresso,
        Latte
    }

    abstract class Beverage
    {
        public string Name { get; set; }
        public abstract decimal Price { get; set; }
        public DrinkSize Size { get; set; }
    }
    class Coffee : Beverage
    {
        public override decimal Price { get; set; }
        public PreferredTemp Temp { get; set; }
        public CoffeeTypes Type { get; set;}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod6Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Address homeaddress = new Address();
            homeaddress.AptNo = 25;
            homeaddress.StreetName = "Elwood";
            homeaddress.City = "Northport";
            homeaddress.State = "NY";
            Console.WriteLine($"Address is {homeaddress.AptNo} {homeaddress.StreetName}, {homeaddress.City}, {homeaddress.State}");
        }
    }
}

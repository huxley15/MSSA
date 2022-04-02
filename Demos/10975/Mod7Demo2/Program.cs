using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            FulltimeEmployee fulltime = new FulltimeEmployee();
            fulltime.LastName = "Wood";
            fulltime.ExtraHours = 20;
            fulltime.Benefits = 200.0m;
            fulltime.BaseSalary = 2000;
            Console.WriteLine("Salary is:" +fulltime.CalculateSal());
            Console.ReadLine();

            ParttimeEmployee parttime = new ParttimeEmployee();

            // Math.PI for circle area
            
        }
    }
}

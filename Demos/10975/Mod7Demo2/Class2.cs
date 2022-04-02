using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Demo2
{
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal BaseSalary { get; set; }
        public int ExtraHours { get; set; }
        public virtual decimal CalculateSal()
        {
            return this.BaseSalary + (this.ExtraHours * 12);
        }
    }

    class FulltimeEmployee : Employee
    {
        public decimal Benefits { get; set; }
        public override decimal CalculateSal()
        {
            return base.CalculateSal() + this.Benefits;
        }
    }

    //domain classes

    class ParttimeEmployee : Employee
    {

    }
}

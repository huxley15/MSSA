using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5._1
{
    enum Department
    {
        Admin,
        Custodial,
        HR,
        IT,
        Payroll
    }

    internal class Employee
    {
        //rest of properties
        public DateTime dob { get; set; }
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmpID { get; set; }
        public Department Dept { get; set; }
    }
}

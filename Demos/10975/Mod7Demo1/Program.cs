using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Demo1
{
    class A
    {

    }
    class Program
    {
        //polymorphism: many forms
        //inheritance demo
        static void Main(string[] args)
        {
            // Person p = new Person(); not allowed to instatiate an abstract base class 
            Instructor instructor = new Instructor();
            instructor.FirstName = "Deepali";
            instructor.LastName = "Kamatkar";
            instructor.lectureHours = 8;
            instructor.labHours = 4;
            instructor.DoWork();
            instructor.Eat();
            instructor.Communicate();

            Console.ReadLine();

            //Instructor obj = new Person(); // not allowed

            Person p = new Instructor(); //cross referencing
            p.Eat(); //called from base class
            p.Communicate(); // called from base class
            Console.ReadLine();

            Student student = new Student();
            student.DoWork();
        }
    }
}

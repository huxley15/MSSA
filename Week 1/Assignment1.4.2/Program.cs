using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Random random = new Random();
            student1._StudentID = random.Next(1,15);
            Console.WriteLine("Please enter student name, starting with first and then last:");
            try
            {
                student1._FirstName = Console.ReadLine();
                student1._LastName = Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Please enter student grade in single letter form");
            try
            {
                student1._StudentGrade = char.Parse(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            student1.DisplayStudentInfo();
            Console.ReadLine();
        }
    }
}

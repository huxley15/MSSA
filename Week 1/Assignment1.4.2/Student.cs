using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._4._2
{
    class Student
    {
        private int studentID;
        private string firstName;
        private string lastName;
        private char studentGrade;

        public int _StudentID
        {
            get
            {
                return this.studentID;
            }
            set
            {
                this.studentID = value;
            }
        }
        public string _FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }
        public string _LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }
        public char _StudentGrade
        {
            get
            {
                return this.studentGrade;
            }
            set
            {
                this.studentGrade = value;
            }
        }
        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Student information: ID = {this.studentID}, Name = {this.firstName} {this.lastName}, Grade = {this.studentGrade}");
        }
    }
}

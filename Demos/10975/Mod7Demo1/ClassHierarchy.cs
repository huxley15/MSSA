using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Demo1
{
    //abstract does not allow us to create object (instantiation) of person
    abstract class Person
    #region personclasscode
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public void Eat()
        {
            Console.WriteLine("I eat to live!!");
        }
        public void Communicate()
        {
            Console.WriteLine("I use English to communicate!!");
        }
        //virtual fucntion allows you to write something that can be changed in the derived class
        //alows you to change the functionality in derived classes if needed
        public virtual void DoWork()
        {
            Console.WriteLine("I do some work!!");
        }
    } 
    #endregion

    class Instructor:Person //is a
    {
        public int lectureHours { get; set; }
        public int labHours { get; set; }
        //hiding (below)
        public new void Eat() //how to hide functionality of something not virtual
        {
            Console.WriteLine("Instructor eats");
        }
        public new void Communicate()
        {
            Console.WriteLine("Communicates in C#");
        }
        public override void DoWork()
        {
            base.DoWork(); //call the functionality of the base base plus add your own

            Console.WriteLine($"I teach for {this.lectureHours} hours daily");
            Console.WriteLine($"I conduct labs for {this.labHours} hours weekly");
        }
    }

    class Student : Person
    {
        public string Subject { get; set; }
        public char Grade { get; set; }
        public override void DoWork()
        {
            base.DoWork();
            Console.WriteLine("I study C#");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region arraydemo
            //Arrays--->system.collections : stack / q/ list..----> System.Collections.Generic
            string name = "c# programming";
            Console.WriteLine("length of string:" + name.Length);
            string substring = name.Substring(0, 3);

            //system: highest level namespace
            //object: highest level class, reference type
            object o, o2;
            o = name;
            o2 = 34; // putting value type into reference = boxing
            int temp = (int)o2 + 23; //converting reference type into value = unboxing

            //Console.WriteLine(o2);

            //arrays
            //datatype [] {name}=new datatype[size];
            //int[] grades = new int[5] { 20, 3, 4, 5, 1 };

            int[] grades;

            Console.WriteLine("Please enter the size of the array:");
            int size = Int32.Parse(Console.ReadLine());
            grades = new int[size];
            Console.WriteLine($"Please enter {size} elements");
            for (int t = 0; t < grades.Length; t++)
            {
                Console.Write($"Element {t + 1}:");
                grades[t] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Elements in array are:");
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
            }
            grades.Reverse();
            Array.Sort(grades);

            string[] names = new string[] { "New York", "Chicago", "Miami" };
            Array.Sort(names);
            foreach (string s in names)//temp name
            {
                Console.WriteLine(s);

            }
            #endregion

            //stacks
            Stack tempstack = new Stack();
            tempstack.Push(7);
            tempstack.Push("NY");
            tempstack.Push(4.5);
            //object o1 = tempstack.Pop();
            foreach(object t in tempstack)
            {
                if(t.GetType().Equals(typeof(string)))
                {
                    string s = (string)t;
                }
                Console.WriteLine(t);
            }

            Queue tempq = new Queue();
            tempq.Enqueue(6);

            ArrayList arrayList = new ArrayList();
            arrayList.Add(6);
            Console.WriteLine(arrayList[0]);

            Console.ReadLine();
        }
    }
}

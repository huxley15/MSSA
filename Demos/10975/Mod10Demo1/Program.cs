using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod10Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            object o;

            int i, j; //stack
            i = 10;
            j = 20;
            o = i; //value to ref is boxing
            int temp =(int) o; //explicit conversion, unboxing
            Swap(ref i,ref j); //parsing address, similar to pointers in C++
            Console.WriteLine($"i: {i} and j:{j}");
            Console.ReadLine();

            StructTest s1 = new StructTest();
            StructTest s2;
            s2 = s1;
            s1.i = 100;
            Console.WriteLine($"struct1 value: {s1.i} and struct2 value: {s2.i}");
            Console.ReadLine();

            ClassTest c1 = new ClassTest();
            ClassTest c2;
            c2 = c1;
            c1.i = 100;
            Console.WriteLine($"class1 value: {c1.i} and class2 value: {c2.i}");
            Console.ReadLine();
            Testclass(c2); //parsed by address
            Test(s2); //parsed by value
        }
        static void Testclass(ClassTest t)
        {

        }
        static void Test(StructTest t) //value type
        {

        }
        static void Swap(ref int num1,ref int num2)
        {
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mathcls.Addnumbers(4,6); //add "static" to methods to simply call them without instantiating class
            Mathcls mathcls = new Mathcls();
            mathcls.Addnumbers(4, 5, 6);
            mathcls.Addnumbers(3, 4);
            mathcls.Addnumbers(4.5F, 6.7F);

            Sayhello(); //static main method can call only static methods directly

            try
            {
                //logic
                throw new InvalidCardException();
            }
            catch (InvalidCardException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
        static void Sayhello()
        {
            Console.WriteLine("Hello");
        }
        static void Sayhello(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}

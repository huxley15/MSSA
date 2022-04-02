using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //exception handling
            int num1, num2;
            Console.WriteLine("Enter 2 numbers:");
            num1 = Int32.Parse(Console.ReadLine());
            num2 = Int32.Parse(Console.ReadLine());

            try
            {
                int result = num1 / num2;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {

            }
            finally
            {
                //mandatory code
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}

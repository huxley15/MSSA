using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Demo4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region while and do while loop
            /* int i = 10;
               while(i>0)
               {
                   Console.WriteLine(i);
                   i--;
               }
               i = 0;
               do
               {
                   i++;
                   Console.WriteLine(i);
               }
               while (i < 19);
               Console.ReadLine(); */
            #endregion

            char choice = 'y';
            while(choice=='y'|| choice=='Y')
            {
                CallMenu();
                Console.WriteLine("Do you want to continue? (Enter y/Y for yes and N/n for no");
                choice = Convert.ToChar(Console.ReadLine());
            }
            Console.ReadLine();
        }
        static void CallMenu()
        {
            Console.WriteLine("Which operation do you want to perform today? Enter the corresponding number.");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Multiplication");
            Console.WriteLine("3. Subtraction");
            Console.WriteLine("Enter your choice:");
            int choice = Int32.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("calling add..");
                    // call function
                    break;
                case 2:
                    //call function
                    break;
                case 3:
                    //call function
                    break;
                default:
                    break;
            }
        }
    }
}

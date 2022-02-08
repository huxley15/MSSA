using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment2._2
{
    class Program
    {
        static string fileName;
        static string filePath = "C:\\MSSAfiles\\";
        static void Main(string[] args)
        {
            string userName;
            int userAge;
            string userAddress;
            Console.WriteLine("Let's create a file to store your information!");
            Console.WriteLine("Enter a name for your personal file:");
            fileName = Console.ReadLine();
            filePath = filePath + fileName;
            StreamWriter sw = null;
            try
            {
                if (!File.Exists(filePath))
                {
                    sw = File.CreateText(filePath);
                    Console.WriteLine("Please enter your name:");
                    userName = Console.ReadLine();
                    Console.WriteLine("Please enter your age:");
                    userAge = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter your address:");
                    userAddress = Console.ReadLine();
                    Console.WriteLine("Enter your favorite thing about Kyle:");
                    Console.ReadLine();
                    Console.WriteLine("Thank you! :)");
                    sw.WriteLine("User's name is " + userName + ", their age is " + userAge + ", and their address is " + userAddress);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sw.Close();
            }
            ReadFromUserData();
            Console.ReadLine();
            File.Delete(filePath);
        }
        
        static void ReadFromUserData()
        {
            StreamReader sr = new StreamReader(filePath);
            string userData = sr.ReadToEnd();
            Console.WriteLine(userData);
            sr.Close();
        }
        
    }
}

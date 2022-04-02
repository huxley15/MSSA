using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //adding system.io here allows you to call IO classes directly without writing System.IO every time

namespace Mod9Demo1
{
    class Program
    {
        static string filename;
        static string path = "C:\\MSSAfiles\\"; //also written @"C:\MSSAfiles\"
        static void Main(string[] args)
        {
            Console.WriteLine("Let's create a file to perform basic file IO operations ");
            Console.WriteLine("Enter a file name:");
            filename = Console.ReadLine();
            path = path + filename;
            StreamWriter sw = null;
            try
            {
                if (!File.Exists(path))
                {
                    sw = File.CreateText(path); //streamwriter gives you a pointer
                    sw.WriteLine("This is the first line..");
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
            Console.WriteLine("These are the file contents:");
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            File.Delete(path);
            Console.ReadLine();
        }
        
    }
}

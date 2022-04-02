using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mod9Demo2
{
    class Program
    {
        static string filepath = @"C:\MSSAfiles\log.txt";
        static void Main(string[] args)
        {
            try
            {
                int result,i;
                i = 10;
                result = i / 0; 
            }
            catch(Exception ex)
            {
                //WritetoFiles(ex.Message + "" + ex.Source +DateTime.Now);
                Appendlines(ex.Message + " " + DateTime.Now + "\n");
            }
            Readfromlog();
            Console.ReadLine();
        }
        static void WritetoFiles(string data)
        {
            StreamWriter sw = new StreamWriter(filepath);
            if (File.Exists(filepath))
            {
                sw.WriteLine(data);
                Console.WriteLine("Contents are written to file..");
                sw.Close(); //sw is the pointer, so if not closed it'll still be using the file
            }
            else
            {
                sw = File.CreateText(filepath);
                sw.WriteLine(data);
                Console.WriteLine("Contents are written to file..");
                sw.Close();
            }
        }

        static void Readfromlog()
        {
            StreamReader stream = new StreamReader(filepath);
            string data = stream.ReadToEnd();
            Console.WriteLine("Contents: " + data);
            stream.Close();
        }

        static void Appendlines(string data)
        {
            //StreamWriter sw;
            File.AppendAllText(filepath, data);

            //sw = File.AppendText(filepath);
            //sw.WriteLine(data);
        }
    }
}

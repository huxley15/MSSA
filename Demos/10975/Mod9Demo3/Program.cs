using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mod9Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo driveInfo = new DriveInfo(@"C:\");
            Console.WriteLine("Name:" + driveInfo.Name + "Free space:"+driveInfo.AvailableFreeSpace);
            DirectoryInfo[] cDirs = new DirectoryInfo(@"C:\").GetDirectories();
            using (StreamWriter sw = new StreamWriter("Cdriveinfo.txt"))
            {
                foreach (DirectoryInfo info in cDirs)
                {
                    sw.WriteLine(info.Name);
                    
                }
            }

            DirectoryInfo dirs = new DirectoryInfo(@"C:\MSSAfiles\");
            FileInfo[] fileInfos = dirs.GetFiles();
            using (StreamWriter sw = new StreamWriter("Fileinfo.txt"))
            {
                foreach (FileInfo info in fileInfos)
                {
                    sw.WriteLine(info.FullName + " " + info.Length);
                }
            }

            Console.ReadLine();
        }
    }
}

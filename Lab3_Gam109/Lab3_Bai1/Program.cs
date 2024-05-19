using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../example.txt";

            using (FileStream fs = new FileStream(path, FileMode.CreateNew, FileAccess.Read))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("UserName: myUserName");
                    sw.WriteLine("password: myPassword");
                }
            }
            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            Console.ReadLine();
        }
    }
}

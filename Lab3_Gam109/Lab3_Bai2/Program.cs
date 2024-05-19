using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Bai2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string username = "1";
            string password = "123";
            string time = "1/10/2000";
            var sw = new StringWriter();
            sw.WriteLine("UserName: " + username);
            sw.WriteLine("password: " + password);
            var content = sw.ToString();

            var sr = new StreamReader(content); 
            string Line1 = sr.ReadLine(); 
            Console.WriteLine("Line1: " + Line1);
            string Line2 = sr.ReadLine();
            Console.WriteLine("Line2: " + Line2);

            string Line = sr.ReadLine();
            while(Line != null)
            {
                Console.WriteLine(Line);
                Line = sr.ReadLine();
            }
            Console.ReadLine();
        }
    }
}

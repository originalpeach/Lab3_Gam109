using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Bai3
{
    public class Program
    {
        static void create(string path)
        {
            Directory.CreateDirectory(path);
            string filePath = Path.Combine(path, "data.txt");
            StreamWriter streamWriter = new StreamWriter(filePath);
            streamWriter.WriteLine("Mssv: pd10037");
            streamWriter.WriteLine("Ho va ten: Dao Khoi Nguyen");
            streamWriter.Dispose();
        }
        static void copy(string sourcepath, string destinationPath)
        {
            if (Directory.Exists(destinationPath) == false)
            {
                Directory.CreateDirectory(destinationPath);
                string[] fileList = Directory.GetFiles(sourcepath);
                foreach (string file in fileList)
                {

                }
            }
        }
        static void Main(string[] args)
        {
            string path1 = "data";
            string path2 = "data2";
            create(path1);
            copy(path1, path2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileHendling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String WriteText = "Hello world";
            //File.WriteAllText("D:/Myfile.txt",WriteText);

            String path = "D:/Myfile.txt";
            if (File.Exists(path))
            {
                File.AppendAllText(path, "This is my modified Data");
                String readText = File.ReadAllText("D:/Myfile.txt");
                Console.WriteLine(readText);
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractClass
{
    internal class Program
    {
        int x = 100;
        int y = 200;
        enum Myvalue
        {
            high = 300,
        }
        static void Main(string[] args)
        {
            Myvalue myvalue = Myvalue.high;
            Program absclass = new Program();
            CsharpClass csharpclass = new CsharpClass();            
            Console.WriteLine(csharpclass.mymaths(absclass.x, absclass.y)+myvalue);
        }
    }
}

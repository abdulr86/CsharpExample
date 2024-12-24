using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace props
{
    class Mydemoprops
    {
        public static int count;

        public Mydemoprops()
        {
            count++;
        }
        public static int  propName
        {
            get { return count; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mydemoprops mydemoprops = new Mydemoprops();
            Mydemoprops mydemoprops1 = new Mydemoprops();
            Mydemoprops mydemoprops2 = new Mydemoprops();

            Console.WriteLine(Mydemoprops.propName);

        }
    }
}

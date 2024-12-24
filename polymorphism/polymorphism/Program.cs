using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Academy academy = new Academy();
            Academy academy2 = new Academy2();

            academy.shree();
            academy2.shree();

        }
    }
}

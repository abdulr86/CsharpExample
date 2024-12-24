using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Academy
    {
        //hi
        int collection1 = 800000;
        int collection12 = 400000;
        static void Main(string[] args)
        {
            Academy total = new Academy();
            BigBranch mybranch = new BigBranch();


            Console.WriteLine("Both Branch Collection is " + (mybranch.yagnikroad(total.collection1) + mybranch.univercityroad(total.collection12)));
        }
    }
}

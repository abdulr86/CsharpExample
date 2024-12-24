using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
     class Academy
    {
        public virtual void shree()
        {
            Console.WriteLine("This is yagnik road branch");
        }
    }
    class Academy2:Academy
    {
        public override void shree()
        {
            Console.WriteLine("This is univercity road branch");
        }

    }


}

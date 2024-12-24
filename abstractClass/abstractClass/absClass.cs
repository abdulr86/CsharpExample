using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractClass
{
    abstract class absClass
    {

        public abstract int mymaths(int a,int b);
    }

    class CsharpClass:absClass
    {

        public override int mymaths(int a,int b)
        {
            return a+b;           
        }
    }
}

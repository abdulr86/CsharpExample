using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface branch1
    {
        int yagnikroad(int collection1);
    }
    interface branch2
    {
        int univercityroad(int collection12);
    }
    class BigBranch : branch1, branch2
    {
        public int yagnikroad(int collection1)
        {
            return collection1;
        }
        public int univercityroad(int collection12)
        {
            return collection12;
        }
    }
}

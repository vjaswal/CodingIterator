using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorFramework
{
    public class EvenNumber:IObjectTest
    {

        public bool Test(object o)
        {
            return (int)o % 2 == 0;
        }
    }
}

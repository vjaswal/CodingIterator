using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorFramework
{
    public class FilteringEnumerator:IEnumerator<object>
    {

        private IEnumerator<object> originalObject;
        private IObjectTest objectTest;
        public object Current { get; private set; }

        public FilteringEnumerator(IEnumerator<object> enumObj, IObjectTest objTest)
        {
            this.originalObject = enumObj;
            this.objectTest = objTest;
        }

        

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            while (originalObject.MoveNext())
            {
                Current = originalObject.Current;
                if (objectTest.Test(Current))
                    return true;
            }
            return false;
        }

        public void Reset()
        {
            originalObject.Reset();
        }

    }
}

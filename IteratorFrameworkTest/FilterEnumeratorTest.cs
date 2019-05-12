using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IteratorFramework;
using System.Collections.Generic;

namespace IteratorFrameworkTest
{
    [TestClass]
    public class FilterEnumeratorTest
    {
        [TestMethod]
        public void TestEvenNumbers()
        {

            var allNumbers = new List<object> { 2, 3, 4, 5, 6, 7 }.GetEnumerator();
            var evenNum = new EvenNumber ();
            FilteringEnumerator filter = new FilteringEnumerator(allNumbers, evenNum);
            filter.MoveNext();
            Assert.AreEqual(2, filter.Current);

            filter.MoveNext();
            Assert.AreEqual(4, filter.Current);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedList;


namespace LinkedListUnitTests
{
    [TestClass]
    public class LLTests
    {
        [TestMethod]
        public void CanCreateLinkedListOfStrings()
        {
           var ll = new LinkedList<string>();

            ll.push("Jae");
            ll.push("Tony Stark");
            ll.print();            
        }

        [TestMethod]
        public void CanCreateLinkedListOfDouble()
        {
            var ll = new LinkedList<double>();

            ll.push(10.1);
            ll.push(23);
            ll.print();
        }

        [TestMethod]
        public void VerifyPopReturnsLastPushedData()
        {
            var ll = new LinkedList<double>();
            int value1 = 12;
            int value2 = 23;
            ll.push(value1);
            ll.push(value2);
            var node = ll.pop();

            Assert.AreEqual(value2, node.data);

        }

        [TestMethod]
        [ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
        public void VerifyHeadCannotbeMovedForNullList()
        {
            var ll = new LinkedList<double>();
            ll.removehead();

           
        }
    }
}

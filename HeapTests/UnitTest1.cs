using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TestingExample;

namespace HeapTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestExample()
        {
            Assert.AreEqual(1 + 1, 2, "Test Description");
        }
    }
}
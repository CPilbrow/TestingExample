using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TestingExample;

namespace HeapTests
{
    [TestClass]
    public class UnitTest1
    {
        Heap heap;
        [TestInitialize]
        public void Initialize() {
        heap = new Heap();
        }

        [TestMethod]
        public void TestExample()
        {
            Assert.AreEqual(1 + 1, 2, "Test Description");
        }

        [TestMethod]
        public void StringComparison()
        {
            Assert.IsTrue(string.Compare("A", "B") < 0);
        }

        [TestMethod]
        public void InsertThenRemove()
        {
            heap.Insert("Hello");
            string result = heap.Remove();
            Assert.AreEqual("Hello", result);
        }

        [TestMethod]
        public void RemoveFromEmptyHeap()
        {
            string result = heap.Remove();
            Assert.IsNull(result);
        }

        [TestMethod]
        public void ABC()
        {
            heap.Insert("A");
            heap.Insert("B");
            heap.Insert("C");
            Assert.AreEqual("A", heap.Remove());
            Assert.AreEqual("B", heap.Remove());
            Assert.AreEqual("C", heap.Remove());
        }

        [TestMethod]
        public void CBA()
        {
            heap.Insert("C");
            heap.Insert("B");
            heap.Insert("A");
            Assert.AreEqual("A", heap.Remove());
            Assert.AreEqual("B", heap.Remove());
            Assert.AreEqual("C", heap.Remove());
        }

    }


}
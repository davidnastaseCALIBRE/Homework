using HeapAssignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class HeapTest
    {
        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException))]
        public void HeapDefaultCharacteristics()
        {
            Heap test = new Heap();
            Assert.AreEqual(0, test.Size());

            test.ExtractMax();
        }

        [TestMethod]
        public void HeapInsert()
        {
            
        }

        [TestMethod]
        public void meh()
        {

        }
    }
}

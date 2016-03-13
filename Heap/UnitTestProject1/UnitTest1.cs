using HeapAssignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException))]
        public void HeapDefaultCharacteristics()
        {
            Heap test = new Heap();
            Assert.AreEqual(0, test.Size());

            test.Size(); //Should throw an exception.
        }

        [TestClass]
        public void HeapInsert()
        {
            
        }

        [TestClass]
        public void meh()
        {

        }
    }
}

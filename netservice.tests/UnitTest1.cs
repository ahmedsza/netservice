using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace netservice.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OneEqualsOne()
        {
            Assert.AreEqual(1, 1);
        }


        [TestMethod]
        public void TwoDoesNotEqualsOne()
        {
            Assert.AreNotEqual(1, 2);
        }
    }
}

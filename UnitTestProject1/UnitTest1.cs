using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingTravis;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Form1 form = new Form1();
            Assert.AreEqual(3, form.getX());
        }
    }
}

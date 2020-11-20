using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingTravis;

namespace Test
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

        [TestMethod]
        public void TestMethod2()
        {
            Form1 form = new Form1();
            Assert.AreEqual(4, form.getY());
        }
    }
}

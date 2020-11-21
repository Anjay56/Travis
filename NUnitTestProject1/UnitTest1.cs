using NUnit.Framework;
using TestingTravis;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            Form1 form = new Form1();
            Assert.AreEqual(4, form.getY());
        }
        
        [Test]
        public void Test2()
        {
            Form1 form = new Form1();
            Assert.AreEqual(3, form.getX());
        }
        
    }
}
namespace NUnitTestProject1
{
    using NUnit.Framework;
    using TestingTravis;

    [TestFixture]
    public class Tests
    {
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
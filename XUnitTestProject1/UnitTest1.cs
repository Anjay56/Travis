using System;
using Xunit;
using TestingTravis;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Form1 form = new Form1();

            Assert.Equal(3, form.getX());
        }

        [Fact]
        public void Test2()
        {
            Form1 form = new Form1();
            Assert.Equal(4, form.getY());
        }
    }
}

using DigitalRoot;
using Xunit;

namespace XUnitTestProject1
{
    public class NumberTest
    {
        private readonly Number num;

        public NumberTest()
        {
            num = new Number();
        }

        [Fact]
        public void Test1()
        {
            Assert.Equal(7, num.DigitalRoot(16));
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(6, num.DigitalRoot(942));
        }

        [Fact]
        public void Test3()
        {
            Assert.Equal(6, num.DigitalRoot(132189));
        }

        [Fact]
        public void Test4()
        {
            Assert.Equal(2, num.DigitalRoot(493193));
        }

        [Fact]
        public void Test5()
        {
            Assert.Equal(5, num.DigitalRoot(-50));
        }

        [Fact]
        public void Test6()
        {
            Assert.Equal(0, num.DigitalRoot(0));
        }

        [Fact]
        public void Test7()
        {
            Assert.Equal(5, num.DigitalRoot(-727379969));
        }

        [Fact]
        public void TestMinMax()
        {
            Assert.Equal(0, num.DigitalRoot(long.MinValue));
            Assert.Equal(0, num.DigitalRoot(long.MaxValue));
        }
    }
}
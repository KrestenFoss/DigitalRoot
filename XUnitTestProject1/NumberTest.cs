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
    }
}
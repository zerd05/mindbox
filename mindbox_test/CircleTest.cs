using Xunit;
using System;
using mindbox;

namespace mindbox_test
{
    public class CircleTest
    {
        [Fact]
        public void CircleTestNegative()
        {
            Assert.Throws<ArgumentException>(() => ShapeMath.GetAreaCircle(-1));
        }

        [Fact]
        public void CircleTestZero()
        {
            Assert.Throws<ArgumentException>(() => ShapeMath.GetAreaCircle(0));
        }

        [Fact]
        public void CircleTestValue()
        {
            Assert.Equal(3.141592653589793, ShapeMath.GetAreaCircle(1));
            Assert.Equal(7853.981633974483, ShapeMath.GetAreaCircle(50));
        }

    }
}
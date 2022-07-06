using Xunit;
using System;
using mindbox;

namespace mindbox_test
{
    public class TriangleTest
    {
        [Fact]
        public void TriangleNagativeSideTest()
        {
            Assert.Throws<ArgumentException>(() => ShapeMath.GetAreaTriangle(-1, 1, 1));
        }

        [Fact]
        public void TriangleZerdSideTest()
        {
            Assert.Throws<ArgumentException>(() => ShapeMath.GetAreaTriangle(0, 1, 1));
        }

        [Fact]
        public void TriangleWrongSideTest()
        {
            Assert.Throws<ArgumentException>(() => ShapeMath.GetAreaTriangle(2, 2, 7));
        }


        [Fact]
        public void TriangleIsRightTest()
        {
            Assert.True(ShapeMath.GetIsRightTriangle(3, 4, 5));
        }


        [Fact]
        public void TriangleGetAreaTest()
        {
            Assert.Equal(6, ShapeMath.GetAreaTriangle(5, 4, 3));
            Assert.Equal(4.14578098794425, ShapeMath.GetAreaTriangle(5, 3, 3));
        }

    }
}

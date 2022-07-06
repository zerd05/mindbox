using Xunit;
using System;
using mindbox;


namespace mindbox_test
{
    public class PolygonTest
    {

        [Fact]
        public void CheckLessThreeArgumentExeption()
        {
            Assert.Throws<ArgumentException>(() => ShapeMath.GetAreaPolygon((8.88, 5.71), (6.42, 6.63)));
        }
        [Fact]
        public void CheckArea()
        {
            Assert.Equal(30.0741, ShapeMath.GetAreaPolygon((8.88, 5.71), (6.42, 6.63), (1.89, 4.02), (3.19, 0.80), (8.82, 1.29)));
        }
    }
}

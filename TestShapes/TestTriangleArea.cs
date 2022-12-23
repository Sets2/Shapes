namespace TestShapes
{
    public class TestTriangleArea
    {
        [Fact]
        public void IsTriangleAreaCorrect()
        {
            Triangle shapeTriangle = new Triangle(3,4,5);
            Assert.True(doubleEquals(6, shapeTriangle.GetArea()));
        }

        [Fact]
        public void IsParametersValid()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(0, 1, 1));
            Assert.Throws<ArgumentException>(() => new Triangle(1, 1, -1));
            Assert.Throws<ArgumentException>(() => new Triangle(1, -1, 1));
            Assert.Throws<ArgumentException>(() => new Triangle(3, 4, 7));
            Assert.Throws<ArgumentException>(() => new Triangle(7, 3, 3));
            Assert.Throws<ArgumentException>(() => new Triangle(4, 7, 3));
        }

        [Fact]
        public void IsRightCorrect()
        {
            Assert.True(new Triangle(3, 4, 5).IsRight);
            Assert.False(new Triangle(1, 1, 1).IsRight);
        }
    }
}

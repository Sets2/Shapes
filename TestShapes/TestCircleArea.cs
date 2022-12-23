namespace TestShapes
{
    public class TestCircleArea
    {
        [Fact]
        public void IsCircleAreaCorrect()
        {
            Circle shapeCircle = new Circle(1);
            Assert.True(doubleEquals(PI, shapeCircle.GetArea()));
        }

        [Fact]
        public void IsParametersValid()
        {
            Assert.Throws<ArgumentException>(() => new Circle(1-0.1*10));
        }
    }
}

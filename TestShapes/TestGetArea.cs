namespace TestShapes
{
    public class TestGetArea
    {
        double PrintArea(IShape shape)
        {
            return shape.GetArea();
        }

        [Fact]
        public void TestPrintArea()
        {
            Circle shapeCircle = new Circle(1);
            Triangle shapeTriangle = new Triangle(3, 4, 5);
 
            double areaCircle = PrintArea(shapeCircle);
            double areaTriangle = PrintArea(shapeTriangle);

            Assert.True(doubleEquals(PI, areaCircle));
            Assert.True(doubleEquals(6, areaTriangle));
        }
    }
}
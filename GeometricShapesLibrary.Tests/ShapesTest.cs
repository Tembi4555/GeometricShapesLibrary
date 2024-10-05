namespace GeometricShapesLibrary.Tests
{
    public class ShapesTest
    {
        [Fact]
        public void TestCircleAreaShape()
        {
            Circle circle = new Circle(12);
            double expected = 452.389;

            double result = circle.AreaShape();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestTriangleAreaShape()
        {
            Triangle triangle = new Triangle(3,4,5);
            double expected = 6;

            double result = triangle.AreaShape();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestIsRightAngledTriangle()
        {
            Triangle triangle = new Triangle(3,4,5);

            bool result = triangle.IsRightAngledTriangle();

            Assert.True(result);
        }
    }
}
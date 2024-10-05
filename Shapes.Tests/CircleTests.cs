namespace Shapes.Tests
{
    public class CircleTests
    {

        [Fact]
        public void Circle_NegativeRadius_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }

        [Fact]
        public void Circle_ZeroRadius_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0));
        }

        [Fact]
        public void CalcArea_ValidRadius_ReturnsCorrectArea()
        {
            Shape circle = new Circle(8);
            double expectedArea = Math.PI * 8 * 8;

            double area = circle.CalcArea();

            Assert.Equal(expectedArea, area);
        }
    }
}
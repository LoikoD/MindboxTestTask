namespace Shapes.Tests
{
    public class TriangleTests
    {
        // Тесты на исключения
        [Fact]
        public void Triangle_InvalidSides_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
        }

        [Fact]
        public void Triangle_ZeroSide_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(0, 3, 5));
        }

        // Тесты на расчет площади
        [Fact]
        public void CalcArea_ValidSides_ReturnsCorrectArea()
        {
            Shape triangle = new Triangle(3, 4, 5);
            double expectedArea = 6; // Площадь треугольника со сторонами 3, 4, 5 = 6

            double area = triangle.CalcArea();

            Assert.Equal(expectedArea, area);
        }

        [Fact]
        public void CalcArea_EquilateralTriangle_ReturnsCorrectArea()
        {
            Shape triangle = new Triangle(3, 3, 3);
            double expectedArea = (Math.Sqrt(3) / 4) * 3 * 3; // Площадь равностороннего треугольника S = sqrt(3)/4 * a^2

            double area = triangle.CalcArea();

            Assert.Equal(expectedArea, area, precision: 5);
        }

        [Fact]
        public void CalcArea_IsoscelesTriangle_ReturnsCorrectArea()
        {
            Shape triangle = new Triangle(5, 5, 4);
            double expectedArea = (1.0 / 4.0) * Math.Sqrt(Math.Pow(5 + 5, 2) - Math.Pow(4, 2)) * 4; // Для равнобедренного треугольника S = 1/4 * sqrt((a+b)^2 - c^2) * c

            double area = triangle.CalcArea();

            Assert.Equal(expectedArea, area, precision: 5);
        }

        // Тесты на прямоугольный треугольник
        [Fact]
        public void IsRightTriangle_ValidRightTriangle_ReturnsTrue()
        {
            var triangle = new Triangle(3, 4, 5);

            bool isRight = triangle.IsRightTriangle();

            Assert.True(isRight);
        }

        [Fact]
        public void IsRightTriangle_ValidNonRightTriangle_ReturnsFalse()
        {
            var triangle = new Triangle(2, 3, 4);

            bool isRight = triangle.IsRightTriangle();

            Assert.False(isRight);
        }
    }
}

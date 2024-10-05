
namespace Shapes
{
    /// <summary>
    /// Класс, представляющий треугольник.
    /// </summary>
    public class Triangle : Shape
    {
        private readonly double sideA;
        private readonly double sideB;
        private readonly double sideC;

        /// <summary>
        /// Создает экземпляр класса <see cref="Triangle"/> с заданными сторонами.
        /// </summary>
        /// <param name="a">Сторона A треугольника.</param>
        /// <param name="b">Сторона B треугольника.</param>
        /// <param name="c">Сторона C треугольника.</param>
        /// <exception cref="ArgumentException">Если одна из сторон меньше или равна 0 или если треугольник с данными сторонами не существует.</exception>
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Стороны треугольника должны быть больше 0");
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Треугольник с данными сторонами не существует");

            sideA = a;
            sideB = b;
            sideC = c;
        }

        /// <summary>
        /// Вычисляет площадь треугольника.
        /// </summary>
        /// <returns>Площадь треугольника.</returns>
        public override double CalcArea()
        {
            double p = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }

        /// <summary>
        /// Проверяет, является ли треугольник прямоугольным.
        /// </summary>
        /// <returns>true, если треугольник прямоугольный; иначе, false.</returns>
        public bool IsRightTriangle()
        {
            double[] sides = [sideA, sideB, sideC];
            Array.Sort(sides);
            return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 1e-10; // Учет погрешностей
        }
    }
}

namespace Shapes
{
    /// <summary>
    /// Класс, представляющий круг.
    /// </summary>
    public class Circle : Shape
    {
        private readonly double radius;

        /// <summary>
        /// Создает экземпляр класса <see cref="Circle"/> с заданным радиусом.
        /// </summary>
        /// <param name="radius">Радиус круга. Должен быть больше 0.</param>
        /// <exception cref="ArgumentException">Если радиус меньше или равен 0.</exception>
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть больше 0");
            this.radius = radius;
        }

        /// <summary>
        /// Вычисляет площадь круга.
        /// </summary>
        /// <returns>Площадь круга.</returns>
        public override double CalcArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
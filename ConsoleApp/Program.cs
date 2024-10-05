using Shapes;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            List<Shape> shapes =
            [
                new Circle(5),
                new Triangle(3, 4, 5),
                new Circle(10)
            ];

            // Вычисление площади фигуры без знания типа фигуры в compile-time
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Площадь фигуры: {shape.CalcArea()}");
            }
        }
    }
}
// See https://aka.ms/new-console-template for more information
internal class TriAngle : Shape
{
    void Shape.Draw(int x, int y)
    {
        Console.WriteLine($"Нарисован треугольник по координатам x={x}, y={y}!");
    }
}
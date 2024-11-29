// See https://aka.ms/new-console-template for more information
internal class RectAngle : Shape
{
    void Shape.Draw(int x, int y)
    {
        Console.WriteLine($"Нарисован прямоугольник по координатам x={x}, y={y}!");
    }
}
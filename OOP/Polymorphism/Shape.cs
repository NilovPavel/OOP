// See https://aka.ms/new-console-template for more information

/// <summary>
/// Интерфейс координат
/// </summary>
interface Shape
{
    /// <summary>
    /// Метод для отрисовки фигуры
    /// </summary>
    /// <param name="x">Декартова координата по оси Х</param>
    /// <param name="y">Декартова координата по оси У</param>
    void Draw(int x, int y);
}
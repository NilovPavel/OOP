// See https://aka.ms/new-console-template for more information
using System.Drawing;

Shape[] shapes = new Shape[] 
{
    new RectAngle(),
    new TriAngle()
};

foreach (Shape shape in shapes)
    shape.Draw(0, 0);
using System;
using System.Collections.Generic;
using lab4.models

class Program
{
    static void Main()
    {

        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Rectangle(10, 20, 30, 40));
        shapes.Add(new Triangle(15, 25, 35, 45));
        shapes.Add(new Circle(50, 50, 10));

        foreach (Shape shape in shapes)
        {
            shape.Draw();
        }
    }
}

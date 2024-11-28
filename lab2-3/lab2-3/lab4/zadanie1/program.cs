using System;
using lab2_3.lab4.zadanie1.models;
namespace lab2_3.lab4.zadanie1
{

    class Program
    {
        static void Main()
        {

            List<Shape> shapes = new List<Shape>();

            shapes.Add(new Rectangle(10, 20, 30, 40));
            shapes.Add(new Triangle(15, 25, 35, 45));
            shapes.Add(new Circle(50, 50, 54));

            foreach (Shape shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}

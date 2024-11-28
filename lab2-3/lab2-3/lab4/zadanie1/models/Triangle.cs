using System;
namespace lab2_3.lab4.zadanie1.models
{
    public class Triangle : Shape
    {
        public Triangle(int x, int y, int height, int width)
            : base(x, y, height, width)
        {
        }

        public override void Draw()
        {

            Console.WriteLine("Rysuję trójkąt.");
        }
    }
}
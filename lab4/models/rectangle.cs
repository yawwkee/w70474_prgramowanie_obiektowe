using System;

namespace models
{
    public class Rectangle : Shape
    {
        public Rectangle(int x, int y, int height, int width)
            : base(x, y, height, width)
        {
        }

        public override void Draw()
        {

            Console.WriteLine("Rysuję prostokąt.");
        }
    }
}

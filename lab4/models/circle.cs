using System;
namespace models
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle(int x, int y, int radius)
            : base(x, y, radius * 2, radius * 2)
        {
            Radius = radius;
        }

        public override void Draw()
        {

            Console.WriteLine("Rysuję okrąg.");
        }
    }
}

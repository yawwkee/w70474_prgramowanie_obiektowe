using System;

namespace models
{
    public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public Shape(int x, int y, int height, int width)
        {
            X = x;
            Y = y;
            Height = height;
            Width = width;
        }


        public abstract void Draw();
    }
}

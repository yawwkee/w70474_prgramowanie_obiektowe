using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab2_3.lab5.zad1
{
    public abstract class Shape
    {
        
        public abstract double CalculateArea();
    }

    public class Square : Shape
    {
        public double X { get; set; }

        public override double CalculateArea()
        {
            return X * X;  
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;  
        }
    }
}




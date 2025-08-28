using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assingment_3
{
    internal abstract class Shape
        {
            public abstract double CalculateArea();
        }

        internal class Circle : Shape
        {
            public double Radius { get; set; }

            public Circle(double radius)
            {
                Radius = radius;
            }

            public override double CalculateArea()
            {
                return Math.PI * Radius * Radius;
            }
        }

        internal class Rectangle : Shape
        {
            public double Length { get; set; }
            public double Width { get; set; }

            public Rectangle(double length, double width)
            {
                Length = length;
                Width = width;
            }

            public override double CalculateArea()
            {
                return Length * Width;
            }
        }
    }
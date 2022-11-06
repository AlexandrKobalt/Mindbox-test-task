using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryFigureAreaCalculator.Figures
{
    public class Circle : Figure
    {
        private double _radius;

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException("Радиус должен быть больше 0");
            }

            _radius = radius;
        }

        public override double CalculateArea()
        {
            return pi * _radius * _radius;
        }
    }
}


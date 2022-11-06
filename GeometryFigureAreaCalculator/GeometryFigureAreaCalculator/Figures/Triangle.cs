using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryFigureAreaCalculator.Figures
{
    public class Triangle : Figure
    {
        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;


        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <=0)
            {
                throw new ArgumentOutOfRangeException("Сторона должна быть больше 0");
            }

            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
        }

        public bool CheckisRightAngledTriangle(double firstSide, double secondSide, double thirdSide) //вынес в отдельную функцию, так как не понятно, требуется ли проверка совместно с расчётом площади
        {
            double[] sides = { firstSide, secondSide, thirdSide };

            double maxValueSide = 0;

            for (int i = 0; i < sides.Length; i++)
            {
                if (sides[i] > maxValueSide)
                {
                    maxValueSide = sides[i];
                }
            }

            return maxValueSide * maxValueSide + maxValueSide * maxValueSide == firstSide * firstSide + secondSide * secondSide + thirdSide * thirdSide;
        }

        public override double CalculateArea()
        {
            double halfPerimeter = (_firstSide + _secondSide + _thirdSide) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - _firstSide) * (halfPerimeter - _secondSide) * (halfPerimeter - _thirdSide));
        }
    }
}


using System;
using Xunit;
using GeometryFigureAreaCalculator.Figures;

namespace GeometryFigureAreaCalculatorTests
{
    public class CalculatorTests
    {
        [Fact]
        public void CircleZeroRadiusTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(0));
        }

        [Fact]
        public void CircleNegativeRadiusTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-1));
        }

        [Fact]
        public void CircleAreaCalculateTest()
        {
            var circle = new Circle(10);
            var circleArea = circle.Area;
            Assert.Equal(314.1592653589793, circleArea);
        }

        [Fact]
        public void TriangleZeroSideTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 3, 5));
        }

        [Fact]
        public void TriangleNegativeSideTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, 3, 5));
        }

        [Fact]
        public void TriangleAreaCalculateTest()
        {
            var triangle = new Triangle(3, 4, 5);
            var triangleArea = triangle.Area;
            Assert.Equal(6, triangleArea);
        }
    }
}

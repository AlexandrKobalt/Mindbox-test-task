using System;

namespace GeometryFigureAreaCalculator
{
    public abstract class Figure
    {
        public double pi = 3.141592653589793; //число пи до 15 знака после запятой прописано, чтобы не тянуть библиотеку и в то же время иметь запас точности

        private readonly Lazy<double> _area; //инициализируем переменную только после переопределения CalculateArea в дочерних классах

        public double Area => _area.Value;
        
        protected Figure()
        {
            _area = new Lazy<double>(CalculateArea);
        }

        public abstract double CalculateArea(); //возвращаем площадь при вызове
        
    }
}

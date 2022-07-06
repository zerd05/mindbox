using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindbox
{
    internal class Triangle : IShape
    {
        double _sideA;
        double _sideB;
        double _sideC;

        public double SideA { get { return _sideA; }}
        public double SideB { get { return _sideB; } }
        public double SideC { get { return _sideC; } }

        public Triangle(double a, double b, double c)
        {
            SetSides(a, b, c);
        }
        public void SetSides(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Сторона не может быть 0 или отрицательной длинны");
            if (!ValidateTriangle(a, b, c))
                throw new ArgumentException("Неверный треугольник");
            _sideA = a;
            _sideB = b;
            _sideC = c; 
        }

        private bool ValidateTriangle(double a, double b, double c)
        {
            if (a + b <= c ||
                a + c <= b ||
                b + c <= a)
                return false;
            return true;
        }


        public double GetArea()
        {
            double a = _sideA;
            double b = _sideB;
            double c = _sideC;
            //https://en.wikipedia.org/wiki/Heron%27s_formula
            return 0.25 * Math.Sqrt((a + b + c) * ( -a + b + c) * (a - b + c) * (a + b - c));
        }

        /// <summary>
        /// Проверка на прямоугольный треугольник
        /// </summary>
        /// <returns></returns>
        public bool IsRight()
        {
            double a = _sideA;
            double b = _sideB;
            double c = _sideC;

            return a * a + b * b == c * c;
        }
    }
}

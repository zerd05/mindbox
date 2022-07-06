using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindbox
{
    internal class Circle : IShape
    {
        private double _radius;
        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value > 0)
                    _radius = value;
                else
                    throw new ArgumentException("Радиус не может быть равен 0 или меньше");
            }
        }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}

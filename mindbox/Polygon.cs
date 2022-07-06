using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindbox
{
    internal class Polygon : IShape
    {
        (double, double)[] _polygonDots;

        public Polygon(params (double, double)[] dots)
        {
            if (dots.Length < 3)
                throw new ArgumentException("Необходимо указать как минимум 3 точки");
            _polygonDots =  dots;
        }

        public double GetArea()
        {
            int num_points = _polygonDots.Length;
            (double, double)[] pts = new (double, double)[num_points + 1];
            _polygonDots.CopyTo(pts, 0);
            pts[num_points] = _polygonDots[0];

            double area = 0;
            for (int i = 0; i < num_points; i++)
            {
                area +=
                    (pts[i + 1].Item1 - pts[i].Item1) *
                    (pts[i + 1].Item2 + pts[i].Item2) / 2;
            }

            return Math.Abs(area);
        }
    }
}

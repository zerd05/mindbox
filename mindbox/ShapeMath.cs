namespace mindbox
{
    public static class ShapeMath
    {
        public static double GetAreaCircle(double radius)
        {
            var circle = new Circle(radius);
            return circle.GetArea();
        }

        public static double GetAreaTriangle(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);
            return triangle.GetArea();
        }

        public static double GetAreaPolygon(params (double, double)[] dots)
        {
            var polygon = new Polygon(dots);
            return polygon.GetArea();
        }

        public static bool GetIsRightTriangle(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);
            return triangle.IsRight();
        }
    }
}
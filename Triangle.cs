using System;

namespace alan_hesaplama
{
    public class Triangle : Shape
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public Triangle(double _Side1, double _Side2, double _Side3)
        {
            Side1 = _Side1;
            Side2 = _Side2;
            Side3 = _Side3;
        }

        public override double calArea()
        {
            double s = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
        }

        public override double calPerimete()
        {
            return Side1 + Side2 + Side3;
        }
    }
}
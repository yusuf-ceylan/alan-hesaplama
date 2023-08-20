using System;

namespace alan_hesaplama
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double _radius)
        {
            Radius = _radius;
        }

        public override double calArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double calPerimete()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
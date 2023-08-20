namespace alan_hesaplama
{
    public class Square : Shape
    {
        public double Side { get; set; }
        public Square(double _Side)
        {
            Side = _Side;
        }

        public override double calArea()
        {
            return Side * Side;
        }

        public override double calPerimete()
        {
            return 4 * Side;
        }
    }
}
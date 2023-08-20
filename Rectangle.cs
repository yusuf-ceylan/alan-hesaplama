namespace alan_hesaplama
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double _width, double _height)
        {
            Width = _width;
            Height = _height;
        }

        public override double calArea()
        {
            return Width * Height;
        }

        public override double calPerimete()
        {
            return 2 * (Width + Height);
        }
    }
}
class Rectangle : Shape
{
    readonly double _length;

    readonly double _width;


    internal Rectangle(string color, double length, double width) : base("Rectangle", color)
    {
        _length = length;
        _width = width;
    }


    internal override double GetArea()
    {
        return _length * _width;
    }
}
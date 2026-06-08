class Circle : Shape
{
    readonly double _radius;


    internal Circle(string color, double radius) : base("Circle", color)
    {
        _radius = radius;
    }


    internal override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}
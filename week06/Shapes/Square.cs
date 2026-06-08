class Square : Shape
{
    readonly double _side;


    internal Square(string color, double side) : base("Square", color)
    {
        _side = side;
    }


    internal override double GetArea()
    {
        return _side * _side;
    }
}
class Shape
{
    readonly string _name;
    string _color;


    internal Shape(string name, string color)
    {
        _name = name;
        _color = color;
    }


    internal string GetName()
    {
        return _name;
    }


    internal string GetColor()
    {
        return _color;
    }


    internal void SetColor(string color)
    {
        _color = color;
    }


    internal virtual double GetArea()
    {
        return 0.0;
    }
}
class Program
{
    static void Main()
    {
        List<Shape> shapes =
        [
            new Square("Blue", 4.0),
            new Rectangle("Gold", 8.1, 4.0),
            new Circle("Green", 8.0)
        ];

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"\n{shape.GetName()}");
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
        }
    }
}
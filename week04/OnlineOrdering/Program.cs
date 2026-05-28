class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        List<Order> orders = new(2);

        List<Product> magicProducts =
        [
            new Product("Sunflower Staff", "f7a", 21, 1),
            new Product("Electric Needle", "f4e", 2.75, 10),
            new Product("Childhood Chip Cookies", "c5r", 0.26, 32)
        ];

        Customer magicCustomer = new(
            "Adelora Sol",
            new Address("4000 East 4000 North", "Camelot", "Loch Nor", "Avalon"));

        orders.Add(new Order(magicProducts, magicCustomer));

        List<Product> officeProducts =
        [
            new Product("Linux Computer", "64lm16x2021", 2032.49, 1),
            new Product("Laser Pointer", "d2b", 1.99, 18000)
        ];

        Customer officeCustomer = new(
            "Hans Smith",
            new Address("10 West 7000 South", "Donville", "Michigan", "United States"));
        
        orders.Add(new Order(officeProducts, officeCustomer));

        foreach (Order order in orders)
        {
            Console.WriteLine("\nPacking Label");
            Console.WriteLine(order.GetPackingLabel());

            Console.WriteLine("Shipping Label");
            Console.WriteLine(order.GetShippingLabel());

            Console.WriteLine($"\nTotal Cost: ${order.GetTotalCost()}\n");
        }
    }
}
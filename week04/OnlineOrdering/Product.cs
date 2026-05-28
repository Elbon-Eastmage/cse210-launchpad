class Product
{
    private readonly string _name;

    private readonly string _productId;

    private readonly double _price;

    private readonly int _quantity;


    internal Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }


    internal double GetBulkCost()
    {
        return _price * _quantity;
    }


    internal string GetLabel()
    {
        return $"{_name}: {_productId}";
    }
}
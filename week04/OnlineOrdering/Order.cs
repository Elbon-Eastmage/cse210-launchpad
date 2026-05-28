class Order
{
    private readonly List<Product> _products;

    private readonly Customer _customer;


    internal Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }


    internal double GetTotalCost()
    {
        double totalCost = 0;

        foreach (Product product in _products)
        {
            totalCost += product.GetBulkCost();
        }

        if (_customer.IsInUnitedStates())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }

        return totalCost;
    }


    internal string GetPackingLabel()
    {
        string packingLabel = string.Empty;
        
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetLabel()}\n";
        }

        return packingLabel;
    }


    internal string GetShippingLabel()
    {
        string shippingLabel = $"{_customer.GetName()}\n{_customer.GetAddress()}";
        return shippingLabel;
    }
}
class Customer
{
    private readonly string _name;

    private readonly Address _address;


    internal Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }


    internal bool IsInUnitedStates()
    {
        return _address.IsUnitedStatesAddress();
    }


    internal string GetName()
    {
        return _name;
    }


    internal string GetAddress()
    {
        return _address.GetFullAddress();
    }
}
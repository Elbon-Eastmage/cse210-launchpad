class Address
{
    private readonly string _street;

    private readonly string _city;

    private readonly string _region;

    private readonly string _country;


    internal Address(string street, string city, string region, string country)
    {
        _street = street;
        _city = city;
        _region = region;
        _country = country;
    }


    internal bool IsUnitedStatesAddress()
    {
        if (_country == "United States" || _country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    internal string GetFullAddress()
    {
        string fullAddress = $"{_street}\n{_city}, {_region}\n{_country}";
        return fullAddress;
    }
}
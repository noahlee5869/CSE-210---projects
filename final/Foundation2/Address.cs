class Address
{
    // Created the variables reqiured for the address.
    public string Street { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }
    public string Country { get; private set; }

    // Method to set up the variables in the Address class.
    public Address(string street, string city, string state, string country)
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
    }

    // Method to return the country string.
    public bool IsInUSA()
    {
        return Country.ToUpper() == "USA";
    }

    // Method to return the full Address.
    public string GetFullAddress()
    {
        return $"{Street}, {City}, {State}, {Country}";
    }
}

class Address
{
    // Created all the variables reqiured for the address.
    public string Street { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }
    public string Country { get; private set; }

    // Method for setting all the address variables.
    public Address(string street, string city, string state, string country)
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
    }

    // Method to print the Address.
    public string GetFullAddress()
    {
        return $"{Street}, {City}, {State}, {Country}";
    }
}
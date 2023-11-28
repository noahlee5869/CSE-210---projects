class Customer
{
    // Created the variables for the Customer.
    public string Name { get; private set; }
    public Address Address { get; private set; }

    // Method to set up the variables.
    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    // Method to return is the address is in the USA or not.
    public bool IsInUSA()
    {
        return Address.IsInUSA();
    }
}

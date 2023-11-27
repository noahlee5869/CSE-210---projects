public class Customer
{
    private string name;
    private Address address;

    public Customer()
    {
        address = new Address();
    }

    public void SetName()
    {
        name = "noah";
    }

    public void SetAddress()
    {
        address.SetAddress();
    }

    public string GetName()
    {
        return name;
    }

    public string GetAddress()
    {
        return address.GetAddress();
    }

    public string GetCountry()
    {
        return address.GetCountry();
    }
}
public class Address
{
    private string address;
    private string country;

    public void SetAddress()
    {
        address = "14617 shawnee gate sw";
        country = "Canada";
    }

    public string GetAddress()
    {
        return address;
    }

    public string GetCountry()
    {
        return country;
    }
}
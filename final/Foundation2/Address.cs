public class Address
{
    private string _address;
    private string _country;
    
    public string GetAddress()
    {
        Console.WriteLine("Please enter your full address in the form: (#, street, city)");
        _address = Console.ReadLine();

        Console.WriteLine("Is this address located in the USA? (yes/no)");
        _country = Console.ReadLine();

        string fullAddress = $"{_address}, {_country}";
        return fullAddress;
    }

    public int GetCountry()
    {
        if (_country == "Yes")
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}

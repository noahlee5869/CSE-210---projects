using System;
public class Customer
{
    private string name;

    public void NewCustomer()
    {
        Address address = new Address();
        address.GetAddress();
        address.GetCountry();
    }

    public string GetName()
    {
        Console.WriteLine("Please enter your name: ");
        name = Console.ReadLine();
        return name;
    }
}
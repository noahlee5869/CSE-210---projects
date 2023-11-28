class Order
{
    // Created variables specific for the order.
    private List<Product> Products { get; set; }
    private Customer Customer { get; set; }

    // Method to set up the variables for the order class.
    public Order(Customer customer)
    {
        Products = new List<Product>();
        Customer = customer;
    }

    // Mehtod to add the product to the products list.
    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    // Method to add the price of the product to the total price, accounts for the country.
    public double GetTotalPrice()
    {
        double totalPrice = 0;

        foreach (var product in Products)
        {
            totalPrice += product.GetTotalPrice();
        }

        
        if (Customer.IsInUSA())
        {
            totalPrice += 5; 
        }
        else
        {
            totalPrice += 35; 
        }

        return totalPrice;
    }

    // Method to print the packing label.
    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (var product in Products)
        {
            packingLabel += $"{product.Name} (ID: {product.ProductId})\n";
        }
        return packingLabel;
    }
    // Method to print the shipping label.
    public string GetShippingLabel()
    {
        return $"Customer: {Customer.Name}\nAddress: {Customer.Address.GetFullAddress()}";
    }
}
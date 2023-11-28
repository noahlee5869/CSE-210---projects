class Product
{
    // Created the Variables for each product.
    public string Name { get; private set; }
    public string ProductId { get; private set; }
    public double Price { get; private set; }
    public int Quantity { get; private set; }

    // Method to set up each variable.
    public Product(string name, string productId, double price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }

    // Method to Return and preform the calculation for total price.
    public double GetTotalPrice()
    {
        return Price * Quantity;
    }
}
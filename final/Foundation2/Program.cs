class Program
{
    static void Main()
    {
        Products lysol = new Products();

        Order order = new Order();
        order.AddProduct(lysol);

        order.CalculateTotalCost();
        Console.WriteLine(order.PackingLabel());
        Console.WriteLine(order.ShippingLabel());

        Console.WriteLine($"Total Cost: ${order.GetTotalCost()}");
    }
}
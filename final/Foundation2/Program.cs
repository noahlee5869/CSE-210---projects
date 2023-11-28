using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Calls and set up the new product.
        Product product1 = new Product("BackPack", "B01", 43.99, 1);
        Product product2 = new Product("NoteBook", "B02", 1.99, 4);
        Product product3 = new Product("Pencils", "B03", 0.99, 20);

        Address CustomerAddress = new Address("315 Yeoman Hall Rd", "Kalispell", "MT", "USA");

        Customer customer = new Customer("Ashton Pratt", CustomerAddress);

        Order order1 = new Order(customer);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Console.WriteLine("Order 1: Packing Label:");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("\nOrder 1: Shipping Label:");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("\nOrder 1 Total Price: $" + order1.GetTotalPrice());

        Product product4 = new Product("Shoes", "S001", 79.99, 1);
        Product product5 = new Product("Socks", "S002", 2.99, 6);

        Order order2 = new Order(new Customer("Caden Carpenter", new Address("4678 Harbor Front Dr", "Idaho Falls", "ID", "USA")));
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine("\nOrder 2 Packing Label:");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("\nOrder 2 Shipping Label:");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("\nOrder 2 Total Price: $" + order2.GetTotalPrice());
    }
}
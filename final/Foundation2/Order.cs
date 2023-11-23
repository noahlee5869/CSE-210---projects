using System;
using System.Collections.Generic;

public class Order
{
    private List<Products> OrderList;
    private int total;
    private List<Customer> CustomerList;

    public Order()
    {
        OrderList = new List<Products>();
        total = 0;
    }

    public void AddProduct(Products product)
    {
        OrderList.Add(product);
    }

    public void Addcustomer(Customer customer)
    {
        CustomerList.Add(customer);
    }

    public void CalculateTotalCost()
    {
        foreach (Products product in OrderList)
        {
            total += product.GetQuantity() * product.GetProductPrice();
        }
    }

    public int GetTotalCost()
    {
        return total;
    }

    public string PackingLabel()
    {
        string PackingLabel = $"This is the packing label total: {total}";
        return PackingLabel;
    }

    public string ShippingLabel()
    {
        string ShippingLabel = $"Name: ";
        return ShippingLabel;
    }
}
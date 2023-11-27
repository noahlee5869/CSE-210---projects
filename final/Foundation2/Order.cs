using System;
using System.Collections.Generic;

public class Order
{
    private List<Products> OrderList;
    private int total;
    private Customer customer;

    public Order()
    {
        OrderList = new List<Products>();
        total = 0;
        customer = new Customer();
    }

    public void AddProduct(Products product)
    {
        OrderList.Add(product);
    }

    public void SetCustomer(Customer customer)
    {
        this.customer = customer;
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
        string packingLabel = $"This is the packing label total: {total}";
        return packingLabel;
    }

    public string ShippingLabel()
    {
        string shippingLabel = $"Name: {customer.GetName()}\nAddress: {customer.GetAddress()} {customer.GetCountry()}";
        return shippingLabel;
    }
}
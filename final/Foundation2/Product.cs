using System;

public class Products
{
    private string ProductName;
    private int ProductPrice;
    private int Quantity;

    public Products()
    {
        ProductName = "Lysol";
        ProductPrice = 10;
        Quantity = 4;
    }

    public int GetQuantity()
    {
        return Quantity;
    }

    public int GetProductPrice()
    {
        return ProductPrice;
    }
}
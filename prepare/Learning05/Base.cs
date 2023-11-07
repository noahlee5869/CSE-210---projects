using System;
using System.Drawing;
using System.Dynamic;
using System.Formats.Asn1;
using System.Reflection.Metadata;

public class Base 
{
    private string Color;

    public double Area;
  
    public Base(string color)
    {
        Color = color;
    }

    public string GetColor()
    {
        return Color;
    }

    public void SetColor(string color)
    {
        Color = color;
    }

    public virtual double GetArea()
    {
        return Area;
    }
}
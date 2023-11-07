using System;
using System.Formats.Asn1;
using System.Net.NetworkInformation;

public class Circle : Base
{
    private double Radius;

    public Circle(string color, double radius) : base (color)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Radius * Radius * Math.PI;
    }
}
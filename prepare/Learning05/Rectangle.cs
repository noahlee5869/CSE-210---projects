using System.Formats.Asn1;

public class Rectangle : Base
{
    private double Length;
    private double Width;

    public Rectangle(string Color, double length, double width) : base(Color)
    {
        Length = length;
        Width = width;
    }

    public override double GetArea()
    {
        return Width * Length;
    }
}

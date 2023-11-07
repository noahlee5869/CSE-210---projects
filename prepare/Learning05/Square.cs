using System.Security.Cryptography.X509Certificates;

public class Square : Base
{
    private double Side;

    public Square(string Color, double side) : base(Color)
    {
        Side = side;
    }

    public override double GetArea()
    {
        return Side * Side;
    }
}

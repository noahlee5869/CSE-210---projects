public class Fraction
{
    private int topNumber;
    private int bottomNumber;

    public Fraction()
    {
        topNumber = 1;
        bottomNumber = 1;
    }

    public Fraction(int upper)
    {
        topNumber = upper;
        bottomNumber = 1;
    }

    public Fraction(int top, int bottom)
    {
        topNumber = top;
        bottomNumber = bottom;
    }

      public string GetFractionString()
    {
        string text = $"{topNumber}/{bottomNumber}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)topNumber / (double)bottomNumber;
    }

}
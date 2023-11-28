class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        this.speed = speed;
    }

    // Override methods for Speed, Distance, and Pace.
    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetDistance()
    {
        return speed * minutes / 60;
    }

    public override double GetPace()
    {
        return 60 / speed;
    }
}
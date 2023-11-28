class Swimming : Activity
{
    private int laps;
    // Method for calculating the laps
    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        this.laps = laps;
    }
    // Override methods for distance, speed and Pace.
    public override double GetDistance()
    {
        return laps * 50.0 / 1000.0 * 0.62;
    }

    public override double GetSpeed()
    {
        return GetDistance() / minutes * 60;
    }

    public override double GetPace()
    {
        return minutes / GetDistance();
    }
}
class Running : Activity
{
    private double distance;

    // Method for getting the distance the user ran.
    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        this.distance = distance;
    }

    // Override methods for distance, speed and Pace.
    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance / minutes * 60;
    }

    public override double GetPace()
    {
        return minutes / distance;
    }
}
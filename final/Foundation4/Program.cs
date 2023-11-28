class Program
{
    // Main function calls each of the different classes together.
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 4), 20, 5.0),
            new Cycling(new DateTime(2022, 11, 5), 30, 6.0),
            new Swimming(new DateTime(2022, 11, 3), 70, 30),
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
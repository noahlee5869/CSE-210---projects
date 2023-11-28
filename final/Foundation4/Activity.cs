using System;
using System.Collections.Generic;
// Class Activity used as the base class for the other activities.
class Activity
{
    // Create's new variables minutes is public because it is shared between all the other classes.
    private DateTime date;
    public int minutes;

    // Created a method for getting the date and minutes.
    public Activity(DateTime date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }


    // Method for displaying the summary to the user of the activity.
    public string GetSummary()
    {
        return $"{date:dd MMM yyyy} - {GetType().Name} ({minutes} min): Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }

    // Create different virtual methods for the other classes to overide.
    public virtual double GetDistance()
    {
        return 0.0;
    }

    public virtual double GetSpeed()
    {
        return 0.0;
    }

    public virtual double GetPace()
    {
        return 0.0;
    }
}
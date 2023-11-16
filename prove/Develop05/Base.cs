using System;
using System.Collections.Generic;

class Base
{
    public string GoalName { get; set; }
    public string GoalDescription { get; set; }
    public int PointValue { get; set; }
    public static List<Base> GoalList = new List<Base>();
    public string fileName;

    public Base()
    {
        // Removed redundant initialization
    }

    public void goalMenu()
    {
        Console.WriteLine("----------------------");
        Console.WriteLine("1. Create new Simple Goal");
        Console.WriteLine("2. Create new Eternal Goal");
        Console.WriteLine("3. Create new Check List Goal");
        Console.WriteLine("----------------------");
        int userInput = int.Parse(Console.ReadLine());

        if (userInput == 1)
        {
            SimpleGoal simpleGoal = new SimpleGoal();
            simpleGoal.GetValues();
            GoalList.Add(simpleGoal);
        }

        Console.WriteLine("Items in list");
        GoalList.ForEach(goal => Console.WriteLine(goal.GoalName));
    }

    public virtual void GetValues()
    {
        Console.WriteLine("Enter goal name: ");
        GoalName = Console.ReadLine();
        Console.WriteLine("Enter goal description: ");
        GoalDescription = Console.ReadLine();
        Console.WriteLine("Enter point value: ");
        PointValue = int.Parse(Console.ReadLine());
    }
}

class SimpleGoal : Base
{
    public override void GetValues()
    {
        base.GetValues(); // Call the base class method to get common values
        // Additional logic specific to SimpleGoal, if needed
    }
}

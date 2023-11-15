using System;
using System.Collections.Generic;

class Base
{
    public string goalName;
    public string goalDescription;
    public int pointValue;
    public int userInput;
    public List<string> GoalList = new List<string>();

    public Base()
    {
        GoalList = new List<string>();
    }

    public void goalMenu()
    {
        Console.WriteLine("----------------------");
        Console.WriteLine("1. Create new Simple Goal");
        Console.WriteLine("2. Create new Eternal Goal");
        Console.WriteLine("3. Create new Check List Goal");
        Console.WriteLine("----------------------");
        userInput = int.Parse(Console.ReadLine());

        if (userInput == 1)
        {
            simpleGoal g1 = new simpleGoal();
            g1.GetValues();
            g1.GetGoalName();
            GoalList.Add(g1.ToString());
        }    
        Console.WriteLine("Items in list");
        Console.WriteLine(GoalList.Count);
    }

    public virtual string GetGoalName()
    {
        return goalName;
    }

}

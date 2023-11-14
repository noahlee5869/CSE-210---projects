using System;
using System.Collections.Generic;

class Base
{
    public Base goalName;
    public Base goalDescription;
    public Base pointValue;
    public int userInput;
    public List<Base> GoalList = new List<Base>();

    public Base()
    {
        GoalList = new List<Base>();
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
            g1.GetGoal();
            GoalList.Add(g1);
        }    
    }

    public virtual List<Base> GetGoal()
    {
        return GoalList;
    }
}

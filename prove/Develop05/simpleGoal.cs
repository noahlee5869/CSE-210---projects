using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class simpleGoal : Base
{
    private List<Base> SimpleGoalList;

    public void GetValues()
    {
        Console.WriteLine("Simple goal: ");
        Console.WriteLine("---------------------");

        Console.WriteLine("Please enter what you want the name of your goal to be: ");
        string goalName = Console.ReadLine();

        Console.WriteLine("Please enter a short description of the goal: ");
        string goalDescription = Console.ReadLine();

        Console.WriteLine("Please enter the amount of points you will receive upon completion of the goal");
        int pointValue;
        while (!int.TryParse(Console.ReadLine(), out pointValue))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer for points.");
        }
    }

    public override List<Base> GetGoal()
    {
        SimpleGoalList = new List<Base>
        {
            goalName,
            goalDescription,
            pointValue
        };
        return SimpleGoalList;
    }
}
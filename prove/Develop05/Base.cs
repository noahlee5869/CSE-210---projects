using System;

class Base
{
    public string goalNames;
    public string goalDescription;
    public int pointValues;
    public int bonusPoints;
    public int bonusCounter;
    public int userInput;
    
    public Base()
    {

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
            Console.WriteLine("Simple goal: ");
            Console.WriteLine("---------------------");
            simpleGoal g1 = new simpleGoal();
            g1.getSimpleGoal();
        }
        else if (userInput == 2)
        {
            Console.WriteLine("Eternal Goal: ");
            Console.WriteLine("---------------------");
            eternalGoal g2 = new eternalGoal();
            g2.geteternalGoal();
        }
        else if (userInput == 3)
        {
            Console.WriteLine("Checklist Goal: ");
            Console.WriteLine("---------------------");
            checklistGoal g3 = new checklistGoal();
            g3.getchecklistGoal();
        }
        else
        {
            Console.WriteLine("Invalid input, please try again.");
        }
        
    }
    public void info()
    {
        Console.WriteLine("Please enter what you what the name of your goal to be: ");
        goalNames = Console.ReadLine();

        Console.WriteLine("Please enter a short description of the goal: ");
        goalDescription = Console.ReadLine();

        Console.WriteLine("Please enter the amount of point you will recieve upon completion of the goal");
        pointValues = int.Parse(Console.ReadLine());
    }

}
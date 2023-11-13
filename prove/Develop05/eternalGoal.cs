using System;

class eternalGoal : Base
{
    
    public eternalGoal()
    {

    }

    public void geteternalGoal()
    {
        Console.WriteLine("Please enter what you what the name of your goal to be: ");
        goalNames = Console.ReadLine();

        Console.WriteLine("Please enter a short description of the goal: ");
        goalDescription = Console.ReadLine();

        Console.WriteLine("Please enter the amount of point you will recieve upon completion of the goal");
        pointValues = int.Parse(Console.ReadLine());
    }
}
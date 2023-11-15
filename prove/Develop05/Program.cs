using System;

class Program
{
    static void Main(string[] args)
    {
        int userInput; // Declare userInput variable

        do
        {
            Console.WriteLine("Your total score is: ");
            Console.WriteLine("Welcome to the Goal game.");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1. Create new goals");
            Console.WriteLine("2. List current goals");
            Console.WriteLine("3. Save current goals");
            Console.WriteLine("4. Load goal");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. To exit program");
            Console.WriteLine("Enter a number: ");
            Console.WriteLine("-------------------------");
            userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                Console.WriteLine("Create a new goals");
                Base b1 = new Base();
                b1.goalMenu();
                b1.GetGoalName();
            }
            else if (userInput == 2)
            {
                Console.WriteLine("List goals");
            }
            else if (userInput == 3)
            {
                Console.WriteLine("Save Goals");
            }
            else if (userInput == 4)
            {
                Console.WriteLine("Load goals");
            }
            else if (userInput == 5)
            {
                Console.WriteLine("Record Event");
            }
            else if (userInput == 6)
            {
                Console.WriteLine("Good luck on your goals!");
            }
            else
            {
                Console.WriteLine("Invalid input, please try again.");
            }

        } while (userInput != 6); // Corrected the condition
    }
}

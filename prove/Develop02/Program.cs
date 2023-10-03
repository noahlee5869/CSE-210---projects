using System;

class Program
{
    static void Main(string[] args)
    {

        void newprompt()
    {
        int UserInput = 0;

        do
        {
            Console.WriteLine("Do you want to continue writing?");
            Console.WriteLine("Enter 1 to contine or 2 to return to main menu.");
            UserInput = int.Parse(Console.ReadLine());
            if (UserInput == 1)
            {
                Prompt prompt = new Prompt();
                prompt.journal = "hot-dogs";
                prompt.PrintJournalLog();
            }
        } while (UserInput != 2);
    }



        int LoopVariable = 0;
        do
        {
            Console.WriteLine("Welcome to the main menu.");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1. New journal entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save file");
            Console.WriteLine("4. Load existing file");
            Console.WriteLine("5. Quit program");
            Console.WriteLine("-------------------------------");
            
            if (int.TryParse(Console.ReadLine(), out LoopVariable))
            {
                if (LoopVariable == 1)
                {
                    Console.WriteLine("New Journal Entry");
                    newprompt();
                }
                else if (LoopVariable == 2)
                {
                    Console.WriteLine("Display Journal");
                }
                else if (LoopVariable == 3)
                {
                    Console.WriteLine("Save file");
                }
                else if (LoopVariable == 4)
                {
                    Console.WriteLine("Load existing file");
                }
                else if (LoopVariable != 5)
                {
                    Console.WriteLine("Invalid entry, please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid option.");
            }

        } while (LoopVariable != 5);
    }
}

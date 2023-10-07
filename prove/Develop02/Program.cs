using System;

public partial class Program
{

// function to print out my main menu
    public void Display()
    {
        Console.WriteLine("Main Menu: ");
        Console.WriteLine("---------------------------");
        Console.WriteLine("1. Write in Journal");
        Console.WriteLine("2. Display Journal");
        Console.WriteLine("3. Save Journal");
        Console.WriteLine("4. Load Journal");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("---------------------------");
    }
    // Main Function with a switch that calls all the different functions together.
   static void Main(string[] args)
    {
        Program main = new Program();
        Journal journal = new Journal();
        int option = 0;

        while (option != 5)
        {
            main.Display();

            option = int.Parse(Console.ReadLine());
            switch (option)
            {
                // First case allows the user to write in the journal.
                case 1:

                    Entry entry1 = new Entry();
                    entry1.addPrompt();
                    Console.WriteLine(entry1.Prompt);
                    entry1.Text = Console.ReadLine();
                    int length = entry1.Text.Length;

                    if (length >= 20)
                    {
                        entry1.Date = DateTime.Now.ToShortDateString();
                        journal.Entries.Add(entry1);
                    }
                    else
                    {
                        Console.WriteLine("Try writing more in journal, try again.");
                        Console.WriteLine("");
                        Console.WriteLine(entry1.Prompt);
                        entry1.Text = Console.ReadLine();
                    }


                    Console.WriteLine("");
                    break;
                // Second case displays all the inputs of the journal.
                case 2:
                    journal.ShowAll();

                    break;
                // Third case saves the file to a name that the user picks.
                case 3:
                    Console.WriteLine("Please enter the name of the file that you want to save to.");
                    journal.newFileName = Console.ReadLine();
                    journal.saveFile();
                    Console.WriteLine("Saved file");

                    break;
                // Fourth case loads a file that has already been saved by name.
                case 4:
                   Console.WriteLine("What is the name of the file that you want to load?");
                   journal.file = Console.ReadLine();
                   journal.loadFile();

                    break;
                // Fith case exits the loop and closes the program.
                case 5:
                    Console.WriteLine("Enjoy your day!");

                    break;
                default:
                    Console.WriteLine("Invalid choice, try again.");

                    break;
            }
        }

    }

}
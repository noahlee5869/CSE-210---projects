using System;
class Program
{
// Main function that calls everything together
    static void Main(string[] args)
    {
        Book b = new Book();
        Console.WriteLine("Welcome, Press 1 to select a random scripture to memorize");
        string input = Console.ReadLine();
        if (input == "1")
        {
            b.GetRandomScripture();
        }
        Scripture scripture = new Scripture(b.getScripture());

        scripture.ShowScripture();
        Console.WriteLine("Press enter to hide words, or 'quit' to exit.");
        string enter = Console.ReadLine();
        while (enter != "quit")
        {
            Console.Clear();
            scripture.ShowScripture();



            Console.WriteLine("Press enter to hide words, or 'quit' to exit.");
            enter = Console.ReadLine();

        }
    }
}

using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter a username: ");
        string UserName = Console.ReadLine();
        return UserName;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favourite number: ");
        string StringFavNumber = Console.ReadLine();
        int FavNumber = int.Parse(StringFavNumber);
        return FavNumber;
    }

    static int SquareNumber(int FavNumber)
    {
        int squaredNumber = FavNumber * FavNumber;
        return squaredNumber;
    }

    static void DisplayResults()
    {
        string UserName = "";
        int FavNumber = 0;
        int squaredNumber = 0;
        DisplayWelcome();
        UserName = PromptUserName();
        Console.WriteLine("Username: " + UserName);
        FavNumber = PromptUserNumber();
        squaredNumber = SquareNumber(FavNumber);
        Console.WriteLine(squaredNumber);
    }
    static void Main(string[] args)
    {
        DisplayResults();
    }
}

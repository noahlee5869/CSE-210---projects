using System;

class Program
{
    static void Main(string[] args)
    {
      //  string last_name = "";

        Console.Write("Please enter your first name: ");
        string first_name = Console.ReadLine();
        Console.Write(first_name);
        Console.WriteLine();
        Console.Write("Please enter your last name: ");
        string last_name = Console.ReadLine();
        Console.WriteLine(last_name);
        Console.Write("Your name is: ");
        Console.Write(last_name);
        Console.Write(" , ");
        Console.Write(first_name);
        Console.Write(last_name);



    }
}
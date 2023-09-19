using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
            Console.WriteLine("Please enter the magic number: ");
            string magic_number = Console.ReadLine();
            int number = int.Parse(magic_number);
            Console.WriteLine("What is your guess?");
            
            int guess;

            do
            {
                string guess_string = Console.ReadLine();
                guess = int.Parse(guess_string);

                if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You got it!");
                }
            } while (guess != number);
            
    }
}
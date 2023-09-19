using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber;

        do
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished: ");
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);
            numbers.Add(userNumber);
        } while (userNumber != 0);

        int sum = 0;
        int numberInputs = 0;
        int largest = int.MinValue;

        foreach (int number in numbers)
        {
            sum += number;
            numberInputs += 1;

            if (number > largest)
            {
                largest = number;
            }
        }

        int average = sum / numberInputs;

        Console.WriteLine("Sum of the numbers in the list: " + sum);
        Console.WriteLine("Average of all the values: " + average);
        Console.WriteLine("Largest value in the list: " + largest);
    }
}

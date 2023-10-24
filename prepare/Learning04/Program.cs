using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Noah Lee", "Programming with classes");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Noah Lee", "Derivatives", "7.1", "1.1, 1.2, and 1.3");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WrittingAssignment a3 = new WrittingAssignment("Noah", "Writting foundations", "Chapter 1: English");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWrittingInformation());


    }
}
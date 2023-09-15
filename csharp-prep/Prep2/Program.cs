using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your grade in a percent:");
        string grade = Console.ReadLine();
        int percent_int = int.Parse(grade);
        string Letter;

        if (percent_int >= 90)
        {
            Letter = "A";
        }
        else if (percent_int >= 80)
        {
            Letter = "B";
        }
        else if (percent_int >= 70)
        {
            Letter = "C";
        }
        else if (percent_int >= 60)
        {
            Letter = "D";
        }
        else
        {
            Letter = "F";
        }

        Console.WriteLine(Letter);


        if (percent_int >= 70)
        {
            Console.WriteLine("Congrats you passed the class");
        }







    }
}
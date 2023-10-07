using System.IO;
using System;
using System.Text;

// Journal Class takes in the users info and puts a date to it.
public class Journal
{
    public List<Entry> Entries = new List<Entry>();
    public void ShowAll()
    {
        Entry journal = new Entry();

        for (int i = 0; i < Entries.Count(); i++)
        {
            Console.WriteLine($"Date: {Entries[i].Date}");
            Console.WriteLine($"Prompt: {Entries[i].Prompt}");
            Console.WriteLine($"Entry: {Entries[i].Text}");
            Console.WriteLine();
        }
    }

// Function to save user inputs to file.
    public string newFileName = "";
    public void saveFile()
    {
        string file = $"{newFileName}";

        using (StreamWriter outputFile = new StreamWriter(newFileName))
        {
            for (int i = 0; i < Entries.Count(); i++)
            {
                outputFile.WriteLine($"Date: {Entries[i].Date}");
                outputFile.WriteLine($"Prompt: {Entries[i].Prompt}");
                outputFile.WriteLine($"Entry: {Entries[i].Text}");
                outputFile.WriteLine();
            }
        }
    }

// Function to load file and displays it to user.
    public string file = "";
    public void loadFile()
    {
        string filename = $"{file}";
        string[] journalText = System.IO.File.ReadAllLines(filename);
        System.Console.WriteLine($"Contents of {filename} is: ");
        foreach (string line in journalText)
        {
            Console.WriteLine("\t" + line);
        }

    }
}
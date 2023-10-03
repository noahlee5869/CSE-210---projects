public class Prompt
{
    public string journal = "";


    public Prompt()
    {
    }
    public void PrintJournalLog()
    {
        Console.WriteLine("What did you eat today?");
        journal = Console.ReadLine();
        Console.WriteLine($"You ate: {journal}");
    }
}

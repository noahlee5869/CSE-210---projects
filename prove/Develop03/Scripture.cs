public class Scripture
{
    private string Reference = "";
    private string Text = "";
    private List<Verse> _verses = new List<Verse>();
    // This seperates the array and creates a new one.
    public Scripture(string scripture)
    {
        string[] scriptSplit = scripture.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
        Reference = scriptSplit[0];
        Text = scriptSplit[1];
        SepVerse();
    }
    // the Sepverse function splits the scripture where there is a new verse detected.
    private void SepVerse()
    {
        string[] splitVerses = Text.Split("\n", StringSplitOptions.RemoveEmptyEntries);
        foreach (string verse in splitVerses)
        {
            Verse newVerse = new Verse(verse);
            _verses.Add(newVerse);
        }
    }
    // this method shows the scripture with the reference and its correlated scriptures
    public void ShowScripture()
    {
        Console.Clear();
        Console.WriteLine($"\n{Reference}");
        foreach (Verse verse in _verses)
        {
            verse.ShowVerse();
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    public void HideWords()
    {
        // Console.Clear();
        foreach (Verse verse in _verses)
        {
            verse.HideWords();
            verse.ShowVerse();
            Console.WriteLine();

        }

    }

}
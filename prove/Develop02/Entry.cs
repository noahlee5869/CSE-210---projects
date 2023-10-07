public class Entry
{
    public string Date = "";
    public string Prompt = "";
    public string Text = "";

// AddPrompt function that calls the random prompt for the user.
    public void addPrompt()
    {
        RandomPromptGenerator p = new RandomPromptGenerator();
        Prompt = p.RandomPrompt();

    }
}
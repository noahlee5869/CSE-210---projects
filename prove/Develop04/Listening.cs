using System;

public class ListingActivity: FullActivity
{

    private Random _random = new Random();

    private List<string> Prompts = new List<string>(){
        "Who is someone you looked up to?",
        "What is your biggest fear?",
        "Who are your closest friends?",
        "How have you improved this year?"
    };

     public ListingActivity()
    {
        SetActivityName("Listening Activity");
        SetDescription("This activity will help you practice listening.");
    }

    public void ListingExercise()
    {
        
    }

    public override void DisplayPrompt()
    {
        Console.WriteLine("List as many respones to the question as you can: ");
        Console.WriteLine($"--{Prompts[_random.Next(Prompts.Count)]}");
        Console.WriteLine("You can start in: ");
        UseTimer().CountDownFrom(5);
        Console.WriteLine();
    }

    private string RandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(Prompts.Count);
        string Prompt = Prompts[index];
        return Prompt;
    }

    private void ListOfThoughts()
    {
        DateTime future = UseTimer().GetFutureTime(GetDuration());
        int items = 0;

        while (!UseTimer().TimesUp(future))
        {
            Console.WriteLine("> ");
            Console.ReadLine();
            items++;
        }
    
        Console.WriteLine($"You wrote a total of {items} thoughts");
        UseTimer().LoadingScreen();
        Console.WriteLine();
    }

    public override void StartActivity()
    {
        DisplayPrompt();
        ListOfThoughts();
    }
}
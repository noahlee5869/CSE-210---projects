using System;
using System.Collections.Generic;

// Class that creates a random prompt for the user to answer.
public class RandomPromptGenerator
{


    public List<string> prompts = new List<string>(){
    "Who was someone interesting you talked to today?",
    "What made your day special?",
    "What is something fun you have planned for this week?",
    "How is your family doing?",
    "Where would you go on vacation right now and why?",
    "What is something that you would've done differently today?",
    "Whats your favorite song to listen to right now?",
};
    public string RandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];

    }
}
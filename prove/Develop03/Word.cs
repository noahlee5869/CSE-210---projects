using System;
using System.Collections.Generic;
public class Word
{
    private string SingleWord;
    private string HiddenWord = "";
    private bool IsHidden = false;
    public Word(string singleWord)
    {
        SingleWord = singleWord;
    }
    public void UnderscoreWord()
    {
        foreach (char letter in SingleWord)
        {
            if (letter != '.' && letter != '!' && letter != '?' &&
                    letter != ',' && letter != ':' && letter != ';')
            {
                HiddenWord += "_";
            }
            else
            {
                HiddenWord += letter;
            }
        }
        IsHidden = true;
    }
    public void ShowWord()
    {
        if (IsHidden)
        {
            Console.Write(HiddenWord);
        }
        else
        {
            Console.Write(SingleWord);
        }
    }

}

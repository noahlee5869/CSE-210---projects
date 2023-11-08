using System;
using System.Collections.Generic;
public class Verse
{
    private List<int> HiddenIndexes = new List<int>();
    private string _verse;
    private List<Word> Words = new List<Word>();

    public Verse(string verse)
    {
        _verse = verse;
        sepWords();
    }
    private void sepWords()
    {
        string[] splitAtWord =
        _verse.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in splitAtWord)
        {
            Word newWord = new Word(word);
            Words.Add(newWord);
        }
    }
    public void ShowVerse()
    {
        foreach (Word word in Words)
        {
            word.ShowWord();
            Console.Write(" ");
        }
    }
    private int GetRandomIndex(int maximum)
    {
        Random random = new Random();
        int randomIndex = random.Next(0, maximum);
        while (HiddenIndexes.Contains(randomIndex))
        {
            randomIndex = random.Next(0, maximum);
        }
        HiddenIndexes.Add(randomIndex);
        return randomIndex;
    }
    public void HideWords()
    {
        int numToHide = Words.Count / 2;
        for (int i = 0; i < 3; i++)
        {
            if (Words.Count == 0)
            {
                return;
            }
            else
            {
                int randomIndex = GetRandomIndex(Words.Count);
                Words[randomIndex].UnderscoreWord();
            }
        }
    }


}
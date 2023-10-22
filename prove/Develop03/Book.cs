using System;
using System.Collections.Generic;
public class Book
{
    private List<string> _scriptures = new List<string>();
    private string _selectedScripture;
    public Book()
    {
        scriptures();
    }
    //contains array of scriptures
    private void scriptures()
    {
        _scriptures.Add("John 3:16 | For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
    }
    //pulls random scripture for memorizing
    public void GetRandomScripture()
    {
        Random random = new Random();
        int index = random.Next(_scriptures.Count);
        _selectedScripture = _scriptures[index];
    }
    public string getScripture()
    {
        return _selectedScripture;
    }
}

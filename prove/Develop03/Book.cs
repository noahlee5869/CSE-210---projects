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
    // has an array of random scripture
    private void scriptures()
    {
        _scriptures.Add("John 3:16 | For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        _scriptures.Add("Mosiah 2:17 | And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.");
    }
    // selects a random scripture to be memorized
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

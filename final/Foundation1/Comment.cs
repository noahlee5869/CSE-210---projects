using System;

public class Comment
{
    // create the two variables used in comments
    public string CommentAuthor;
    public string CommentMessage;
    // method to print the comments
    public void PrintComment()
    {
        Console.WriteLine($"User: {CommentAuthor} Comment: ({CommentMessage})");
    }
}
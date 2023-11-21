using System;

public class Comment
{
    public string CommentAuthor;
    public string CommentMessage;
    public void PrintComment()
    {
        Console.WriteLine($"User: {CommentAuthor} Comment: ({CommentMessage})");
    }
}
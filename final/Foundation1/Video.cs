public class Video
{
    public string VideoDescription;
    public int VideoLength;
    public string VideoName;
    public List<Comment> _comment = new List<Comment>();

    public void Display()
    {
        Console.WriteLine($"Name: {VideoName}");
        Console.WriteLine($"Description: {VideoDescription}");
        Console.WriteLine($"Length: {VideoLength} seconds");
        Console.WriteLine($"Number of comments: {_comment.Count}");
        Console.WriteLine("Comments: ");
        
        foreach (Comment comment in _comment)
        {
            comment.PrintComment();
        }
    }
}

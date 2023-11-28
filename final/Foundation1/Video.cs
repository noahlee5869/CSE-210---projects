public class Video
{
    // sets up the different variables related to the video as well as a list for the comments.
    public string VideoAuthor;
    public int VideoLength;
    public string VideoName;
    public List<Comment> _comment = new List<Comment>();
    // Method used to print the video information and add to the list of comments.
    public void Display()
    {
        Console.WriteLine($"Name: {VideoName}");
        Console.WriteLine($"Author: {VideoAuthor}");
        Console.WriteLine($"Length: {VideoLength} seconds");
        Console.WriteLine($"Number of comments: {_comment.Count}");
        Console.WriteLine("Comments: ");
        
        foreach (Comment comment in _comment)
        {
            comment.PrintComment();
        }
    }
}

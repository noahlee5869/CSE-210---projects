using System;

class Program
{
    public static Video video1;
    // Main function to create all the video's and comments, and print everything
    static void Main(string[] args)
    {
        Comment Comment1 = new Comment();
        Comment1.CommentAuthor = "Matt";
        Comment1.CommentMessage = "This is a great Video";

        Comment Comment2 = new Comment();
        Comment2.CommentMessage = "Very Helpful";
        Comment2.CommentAuthor = "Noah";

        Comment Comment3 = new Comment();
        Comment3.CommentAuthor = "Nick";
        Comment3.CommentMessage = "This doesn't make any sense";

        Comment Comment4 = new Comment();
        Comment4.CommentMessage = "How weird";
        Comment4.CommentAuthor = "Juan";

        Comment Comment5 = new Comment();
        Comment5.CommentAuthor = "Caden";
        Comment5.CommentMessage = "Very interesting";

        Comment Comment6 = new Comment();
        Comment6.CommentMessage = "So fun!";
        Comment6.CommentAuthor = "Jeff";

        Comment Comment7 = new Comment();
        Comment7.CommentAuthor = "Mike";
        Comment7.CommentMessage = "Thanks for the Video";

        Video Video1 = new Video();
        Video1.VideoName = "How to code in python";
        Video1.VideoDescription = "Programming bro's";
        Video1.VideoLength = 1000;
        Video1._comment.Add(Comment1);
        Video1._comment.Add(Comment2);

        Video Video2 = new Video();
        Video2.VideoName = "Engineering Tutor";
        Video2.VideoDescription = "Engineering 101";
        Video2.VideoLength = 2000;
        Video2._comment.Add(Comment3);
        Video2._comment.Add(Comment4);

        Video Video3 = new Video();
        Video3.VideoName = "Cooking Bro";
        Video3.VideoDescription = "How to make bread";
        Video3.VideoLength = 3000;
        Video3._comment.Add(Comment5);
        Video3._comment.Add(Comment6);
        Video3._comment.Add(Comment7);

        Video1.Display();
        Console.WriteLine();
        Video2.Display();
        Console.WriteLine();
        Video3.Display();
    }
}

using System;

public class Video
{
    // Member variables for the video
    private string _title; 
    private string _author; 
    private int _length; 
    private List<Comment> _comments = new List<Comment>(); 

    // Constructor to initialize the video object
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;

    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method to get the number of comments on the video
    public int NumberOfComments()
    {
        return _comments.Count;
    }

    // Method to display the details of the video and its comments
    public void DisplayVideo()
    {
       
        Console.WriteLine($"{_title} by {_author} ({_length} seconds)"); 
        Console.WriteLine($"Comments: ({NumberOfComments()})");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.DisplayComments());
        }
        Console.WriteLine();
    }
}
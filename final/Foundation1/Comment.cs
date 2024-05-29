using System;

public class Comment
{
    // Name of the person who post the comment and text
    private string _name;
    private string _text;

    // Constructor to initalize a comment object
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    // Method to display the comment
    public string DisplayComments()
    {
        return $"> {_name}: {_text}";
    } 
}
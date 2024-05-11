using System;

public class Reference
{
    // Private member variables that encapsulate the 
    // functionality of the reference class
    private int _chapter;
    private string _book;
    private int _verse;
    private int _endVerse;

    // Constructor that assigns values to the member variables if 
    // there is only one verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;

    }
    
    // Constructor that assigns values to the member variables if 
    // there is more than one verse
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // Method that returns a string with the book, the chapter, the verse(s)
    // for a scripture
    public string GetDisplayText()
    {
        // If the end verse = 0 it will return a string with only one verse
        // but if the enverse exists it will return the reference with the first and last verse
        if (_endVerse == 0)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }

}
using System;

public class Word
{
    // Private member variables that encapsulate the functionality
    // of the word class, one for text(it will hold each word) and one
    // for isHidden (it will hold if a word is hidden or not)
    private string _text;
    private bool _isHidden;

    // This construct sets the word object and its default state as false
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    // This method sets the value of the word as hidden
    public void Hide()
    {
        _isHidden = true;
    }
    // This method sets the value of the word as visible
    public void Show()
    {
        _isHidden = false;
    }
    // This method returns if the word is hidden or not
    public bool IsHidden()
    {
        return _isHidden; 
    }
    // This method displays the word if is not hidden
    // and if its hidden displays only a string of ____ to hide the word
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return "____";
        }
        else
        {
            return _text;
        }
    }
}
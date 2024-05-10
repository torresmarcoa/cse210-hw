using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {

        _reference = reference;

        string[] words = text.Split(" ");

        foreach (string word in words)
        {
            _words.Add(new Word(word));
        } 
    }
    public void HideRandomWords(int numberToHide)
    {

    }
    public string GetDisplayText()
    {
        string referenceDisplay = _reference.GetDisplayText();
        string scriptureDisplay = "";

          foreach (Word word in _words)
    {
        scriptureDisplay += word.GetDisplayText() + " ";
    }

        return $"{referenceDisplay} {scriptureDisplay}";
    }
    public bool IscompletelyHidden()
    {
        return true;
    }

}
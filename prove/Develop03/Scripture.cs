using System;

public class Scripture
{
    // Private member variables to store the scripture's reference 
    // and words
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    // Constructor to intialize the scripture with a given reference
    // and text
    public Scripture(Reference reference, string text)
    {

        _reference = reference;

        // Splits the whole scripture into words and store each word 
        // in a list
        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            // Adds each word to the list as a word object
            _words.Add(new Word(word));
        }
    }

    // Method to randmoly hide a specified number of words in the scripture
    public void HideRandomWords(int numberToHide)
    {
        // Creating a random number generator
        Random random = new Random();

        // For loop that iterates the _words list and hide the specific number
        // of words
        for (int i = 0; i < numberToHide; i++)
        {
            // If all the words are hidden break the loop
            if (IscompletelyHidden())
            {
                break;
            }

            // Initializing a variable to store the random selected index to hide
            int indexHiddenWords;
            // do-while loop that selects the random index to hide (if its aleready
            // hidden it will ignore it)
            do
            {
                indexHiddenWords = random.Next(0, _words.Count);
            } while (_words[indexHiddenWords].IsHidden());

            // Hide the selected word
            _words[indexHiddenWords].Hide();
        }
    }

    // Method to generate the display text of the scripture and the reference
    public string GetDisplayText()
    {
        // Initializing the variable that display the reference
        string referenceDisplay = _reference.GetDisplayText();
        
        // Generate the display text of the scripture's words
        string scriptureDisplay = "";
        foreach (Word word in _words)
        {
            scriptureDisplay += word.GetDisplayText() + " ";
        }

        // Hide a specific number of words in the scripture
        HideRandomWords(3);

        // Returns the formatted display text of the scripture 
        return $"{referenceDisplay}: {scriptureDisplay}";
    }

    // Method to check if all words are completely hidden
    public bool IscompletelyHidden()
    {

        // For each loop that iterates through all the words in the scripture
        // if any word is not hidden it will return false.
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
            else
            {
                
            } 
        }

        // If all the words are hidden retrn true
        return true; 
    }

}
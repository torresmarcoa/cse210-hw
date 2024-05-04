using System;

public class Entry 
{
    // member variables for date, promptext and entrytext
    public string _date;
    public string _promptText;
    public string _entryText;

    // method to display the entry details
    public void Display()
    {
        Console.WriteLine($"{_date} : {_promptText}");
        Console.WriteLine(_entryText);
    }
}
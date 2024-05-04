using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
    // creates a list named _entries
    public List<Entry> _entries = new List<Entry>();

    // method to add new entries
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // method to display all the entries
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    // method to save all the entries to a file
    public void SaveToFile(string file)
    {

        // check if there are entries in the journal
        if (_entries.Count == 0)
        {
            Console.WriteLine("Sorry you cannot save an empty journal.");
            // exits the method if the journal is empty
            return;
        }
        // variable that stores the filename proportionated by the user
        string fileName = file + ".csv";

        // writes a new file with the name proportionated by the user
        // if the file exists each new entry will be added
        using (StreamWriter outputFile = new StreamWriter(fileName, append: _entries.Count > 0))
        {
            // loop that iterates each entry and add it to the file
            foreach (Entry entry in _entries)
            {
                // checks if the prompt text contains commas.
                // if it does, it wraps it in double quotes to avoid issues with the CSV format.
                string promptText = entry._promptText.Contains(',') ? $"\"{entry._promptText}\"" : entry._promptText;
                string entryText = entry._entryText.Contains(',') ? $"\"{entry._entryText}\"" : entry._entryText;
                
                // writes a line to the CSV file with the date, prompt text, and entry text, separated by commas.
                outputFile.WriteLine($"{entry._date},{promptText},{entryText}");
            }
        }
        Console.WriteLine($"Journal saved to {fileName}.csv");
    }
    public void LoadFromFile(string file)
    {
        string fileName = file + ".csv"; 

        // if the file (filename) exists 
        // the program will read the elements
        if (File.Exists(fileName))
        {
            // clears previous elements in the list
            _entries.Clear();

            // open the file for reading using Stream reader
            using (StreamReader inputFile = new StreamReader(fileName))
            {
                // variable that stores each read line in the file
                string line; 

                // reads each line of the file untill the end 
                while ((line = inputFile.ReadLine()) != null)
                {
                    string[] parts = line.Split(",");


                    // creates a new instance of entry 
                    // and add it to the _entries list
                    if (parts.Length >= 3)
                    {
                        string date = parts[0];
                        string promptText = parts[1];
                        string entryText = parts[2];

                        Entry entry = new Entry();
                        entry._date = date;
                        entry._promptText = promptText;
                        entry._entryText = entryText;

                        _entries.Add(entry);
                    }
                }
            }
        }
        // if the file (filename) does not exists 
        //  the program will inform
        else
        {
            Console.WriteLine($"The file {fileName} does not exist");
        }
    }
}
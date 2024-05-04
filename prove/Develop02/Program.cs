using System;

class Program
{
    static void Main(string[] args)
    {

        /* This program exceeds the core requirements by using a CSV 
        file to improve the process of savingthe entries, the created 
        file can be opened in Excel also the previous entries will not 
        be deleted if the user uses the same file to save new entries. */ 


        // variable that stores the user's choice
        String choice;
        // creates a datetime object
        DateTime currentTime = DateTime.Now;
        // creates a journal instance
        Journal journal = new Journal();

        Console.WriteLine("Welcome to the Journal Program");

        // do-while loop that repeats the program untill the user chooses to quit
        do
        {
            // printing the options for the user
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            
            // reads the user's choice
            choice = Console.ReadLine();

            // if-else block that handles the user's choice
            if (choice == "1")
            {
                // if the user chooses to write a journal entry
                // generates a random prompt
                PromptGenerator promptGenerator = new PromptGenerator();

                string randomPrompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine(randomPrompt);

                // creates a new entry
                Entry newEntry = new Entry();
                newEntry._date = currentTime.ToShortDateString();
                newEntry._promptText = randomPrompt;
                Console.Write("> ");
                newEntry._entryText = Console.ReadLine();

                // adds the new entry to the jorunal
                journal.AddEntry(newEntry);
                
            }
            else if (choice == "2")
            {
                // displays all the entries in the journal
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                // asks the user for the file name and load the entries from the file
                Console.Write("Enter file name (without extension): ");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
            }
            else if (choice == "4")
            {
                // asks for the file name and save entries to the file
                Console.Write("Enter file name (without extension): ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
                
            }
            else if (choice == "5")
            {
                // prints a goodbye message and ends the do-while loop clossing the program
                Console.WriteLine("Goodbye");
            }
            else 
            {
                // if the user enters an invalid choice notifies the user
                Console.WriteLine("Invalid Choice");
            }
            Console.WriteLine();
        }
        while (choice != "5");
    }
}
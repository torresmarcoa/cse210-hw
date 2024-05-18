using System;
using System.Data;

public class ListingActivity : Activity
{
    // Variable to store the user list count
    private int _count;
    // List that stores the prompts
    private List<String> _prompts = new List<string>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    // Constructor that initializes the name and description of the activity
    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    // Method to run the program
    public void Run()
    {
        DisplayStartingMessage();

        // Prompt the user to be ready and shows the question
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"____ {GetRandomPrompt()} _____");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> answers = GetListFromUser();

        // Counts the user list items 
        _count = answers.Count;

        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();

        Console.Clear();
    }

    // Method to get a randmo prompt
    public string GetRandomPrompt()
    {
        Random random = new Random();

        int randomIndex = random.Next(0, _prompts.Count);

        return _prompts[randomIndex];
    }

    // Method to get the user's list
    public List<string> GetListFromUser()
    {
        List<string> answers = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        // Loop that gets the user item and store it in a list
        do
        {
            Console.Write("> ");
            answers.Add(Console.ReadLine());
        }
        while (DateTime.Now < endTime);

        Console.Clear();

        // Return the list
        return answers;
    }

}
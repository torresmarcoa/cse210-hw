using System;
using System.Data;

public class ListingActivity : Activity
{

    private int _count;
    private List<String> _prompts = new List<string>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"____ {GetRandomPrompt()} _____");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> asnwers = GetListFromUser();
        
        _count = asnwers.Count;

        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();

        Console.Clear();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();

        int randomIndex = random.Next(0, _prompts.Count);

        return _prompts[randomIndex];
    }

    public List<string> GetListFromUser()
    {
        List<string> answers = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        do
        {
            Console.Write("> ");
            answers.Add(Console.ReadLine());
        }
        while (DateTime.Now < endTime);

        Console.Clear();

        return answers;
    }

}
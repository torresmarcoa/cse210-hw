using System;
using System.Data;

public class ReflectingActivity : Activity
{
    // Lists of prompts and questions for the activity
    private List<string> _prompts = new List<string>{"Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless." };
    private List<string> _questions = new List<string>{"Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?", "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"};

    // Constructor that initializes the name and description of the activity
    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    // Method to run the activity
    public void Run()
    {
        DisplayStartingMessage();

        // Display a prompt for the user
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience");
        Console.Write($"You may begin in: ");
        ShowCountDown(5);

        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        // Loop to display a question for the user until the duration is reached 
        do
        {
            DisplayQuestions();
            ShowSpinner(10);
            Console.WriteLine();
        }
        while (DateTime.Now < endTime);

        DisplayEndingMessage();

        Console.Clear();

    }

    // Method to get a random prompt
    public string GetRandomPrompt()
    {
        Random random = new Random();

        int randomIndex = random.Next(0, _prompts.Count);

        return _prompts[randomIndex];
    }

    // Method to get a random question
    public string GetRandomQuestion()
    {
        Random random = new Random();

        int randomIndex = random.Next(0, _questions.Count);

        return _questions[randomIndex];
    }

    // Method to display the prompt
    public void DisplayPrompt()
    {
        Console.WriteLine($"_____ {GetRandomPrompt()} _____");
    }

    // Method to dislpay the random question
    public void DisplayQuestions()
    {
        Console.Write($"> {GetRandomQuestion()} -");
    }
}
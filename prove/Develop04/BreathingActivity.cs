using System;
using System.Data;

public class BreathingActivity : Activity
{
    // Constructor that initializes the activity with a specific name and description
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    // Method to run the activity
    public void Run()
    {
        DisplayStartingMessage();

        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        // Loop to guide the user
        do
        {
            Console.WriteLine();
            Console.Write("Breath In... ");
            ShowCountDown(5);
            Console.WriteLine("");
            Console.Write("Breath Out... ");
            ShowCountDown(5);
            Console.WriteLine();
        }
        while (DateTime.Now < endTime);


        DisplayEndingMessage();

        Console.Clear();

    }
}
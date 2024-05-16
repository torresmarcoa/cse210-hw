using System;
using System.Data;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

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
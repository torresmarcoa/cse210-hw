using System;
using System.Data;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    // Protected variables that store the name, description and duration
    protected string _name;
    protected string _description;
    protected int _duration;

    // Constructor that initialize the fields with default values
    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }

    // Method to display the starting message and prompts for the 
    // activity's duration
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready");
        ShowSpinner(5);
        Console.Clear();
    }

    //  Method to display the ending message once the activity is completed
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        Thread.Sleep(500);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity");
        ShowSpinner(5);
        Console.Clear();

    }

    // Method to show a spinner animation for a specific duration
    public void ShowSpinner(int seconds)
    {
        List<string> strings = new List<string>{"┐","┘","┤","┼","├","└","┌"};
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        
        int i = 0;
        do
        {
            string s = strings[i];
            Console.Write(s);
            Thread.Sleep(100);
            Console.Write("\b \b");
            i++;
            
            if (i >= strings.Count())
            {
                i = 0;
            }
        }
        while (DateTime.Now < endTime);
    }

    // Method to show a countdown tomer for a scific duration 
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
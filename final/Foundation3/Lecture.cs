using System;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;

public class Lecture : Event
{

    // Member variables specific to the lecture event
    private string _speaker; 
    private int _capacity;

    // constructor that initializes the Lecture object
    public Lecture(string title, string description, string date, string time, Address address, string type, string speaker, int capacity) : base(title, description, date, time, address, type)
    {
        _speaker = speaker; 
        _capacity = capacity;
    }

    // Method to get the full details for the lecture event
        public void GetFullDetails()
    {
        Console.WriteLine($"Type: {_type}");
        Console.WriteLine($"{_title} - {_description}");
        Console.WriteLine($"{_date} @ {_time}");
        Console.WriteLine($"{_address.GetAddressString()}");
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");
        Console.WriteLine();
    }
}
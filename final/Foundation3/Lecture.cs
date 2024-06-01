using System;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;

public class Lecture : Event
{
    private string _speaker; 
    private int _capacity;


    public Lecture(string title, string description, string date, string time, Address address, string type, string speaker, int capacity) : base(title, description, date, time, address, type)
    {
        _speaker = speaker; 
        _capacity = capacity;
    }

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
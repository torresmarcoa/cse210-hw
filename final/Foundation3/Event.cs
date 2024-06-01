using System;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;

public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    protected string _type;

    public Event(string title, string description, string date, string time, Address address, string type)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = type;
    }

    public void GetStandartDetails()
    {
        Console.WriteLine($"{_title} - {_description}");
        Console.WriteLine($"{_date} @ {_time}");
        Console.WriteLine($"{_address.GetAddressString()}");
        Console.WriteLine();
    }
    public void GetShortDescription()
    {
        Console.WriteLine($"{_type} - {_title} - {_date}");
        Console.WriteLine("=================================");
        Console.WriteLine();
    }
}
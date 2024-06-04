using System; 

public class OutdoorGathering : Event
{
    // Member variable for the weather
    private string _weather;

    // Constructor that initializes the outdoor event
    public OutdoorGathering (string title, string description, string date, string time, Address address, string type, string weather) : base (title, description, date, time, address, type)
    {
        _weather = weather; 
    }

    // Get full details for the outdoor event
        public void GetFullDetails()
    {
        Console.WriteLine($"Type: {_type}");
        Console.WriteLine($"{_title} - {_description}");
        Console.WriteLine($"{_date} @ {_time}");
        Console.WriteLine($"{_address.GetAddressString()}");
        Console.WriteLine($"Weather: {_weather}");
        Console.WriteLine();
    }
}
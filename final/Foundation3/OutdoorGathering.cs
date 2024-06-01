using System; 

public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering (string title, string description, string date, string time, Address address, string type, string weather) : base (title, description, date, time, address, type)
    {
        _weather = weather; 
    }

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
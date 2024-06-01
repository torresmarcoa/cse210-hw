using System;

public class Address
{
    // Variables for the full address
    private string _street;
    private string _city; 
    private string _stateProv;
    private string _country; 

    // Constructor that initializes the address
    public Address(string street, string city, string stateProv, string country)
    {
        _street = street;
        _city = city;
        _stateProv = stateProv;
        _country = country; 
    }

    // Method that returns the full address as a formated string
    public string GetAddressString()
    {
        return $"{_street}\n{_city}, {_stateProv}, {_country}";
    }
}
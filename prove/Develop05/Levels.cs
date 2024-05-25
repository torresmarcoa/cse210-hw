using System;
using System.Data;
using System.Runtime.CompilerServices;

public class Levels
{
    // Variables to store the level, points and points to next level
    private int _currentLevel;
    private int _pointsToNextLevel;
    private int _currentScore;

    // Default constructor to initialize levels to starting values 
    public Levels()
    {
        _currentLevel = 1;
        _pointsToNextLevel = 100;
        _currentScore = 0;
    }

    // Constructor to initialize levels with custom values for the load
    public Levels(int currentLevel, int pointsToNextLevel, int currentScore)
    {
        _currentLevel = currentLevel;
        _pointsToNextLevel = pointsToNextLevel;
        _currentScore = currentScore;
    }

    // Method to display level details to the user
    public void GetDetails()
    {
        int pointsNeeded = _pointsToNextLevel - _currentScore;
        Console.WriteLine($"Your current Level is {_currentLevel}");
        Console.WriteLine($"Earn {pointsNeeded} to reach the next level");
    }

    // Method to add points and check if the player has reached the next level
    public void AddPoints(int points)
    {
        _currentScore += points;
        CheckLevelUp();
    }

    // Method to check if the player has reached the next level
    public void CheckLevelUp()
    {
        while (_currentScore >= _pointsToNextLevel)
        {
            _currentScore -= _pointsToNextLevel;
            _currentLevel++;
            _pointsToNextLevel = CalculatePointsForNextLevel();
            DisplayLevelUpMessage();
        }
    }


    // Method to display a message when the player levels up   
    private void DisplayLevelUpMessage()
    {
        Console.WriteLine($"Congratulations! You've reached level {_currentLevel}!");
    }

    // Method to calculate points needed for the next level

    public int CalculatePointsForNextLevel()
    {
        return (int)(_pointsToNextLevel * 1.2);
    }

    // Method to get a string representation of the Levels object

    public string GetStringRepresentation()
    {
        return $"{_currentLevel}|{_pointsToNextLevel}|{_currentScore}";
    }

    // Method to deserialize a string representation and create a Levels object to load the level and points to next level
    public static Levels FromStringRepresentation(string representation)
    {
        string[] parts = representation.Split('|');
        return new Levels(int.Parse(parts[0]), int.Parse(parts[1]), int.Parse(parts[2]));
    }
}
using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Runtime.Serialization;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        string choice;

        do
        {
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options");
            Console.WriteLine("     1. Create a New Goal");
            Console.WriteLine("     2. List Goals");
            Console.WriteLine("     3. Save Goals");
            Console.WriteLine("     4. Load Goals");
            Console.WriteLine("     5. Record Events");
            Console.WriteLine("     6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
            else if (choice == "6")
            {
                Console.WriteLine("Good bye");
            }
            else
            {
                Console.WriteLine("Not a valid option");
            }
        }
        while (choice != "6");

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
    }
    public void ListGoalNames()
    {
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetName()}");
            i++;
        }
    }
    public void ListGoalDetails()
    {
        int i = 1;
        foreach (Goal goal in _goals)
        {

            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
            i++;
        }
    }
    public void CreateGoal()
    {
        string goalChoice;
        string name;
        string description;
        int points;

        Console.WriteLine("The types of goals are:");
        Console.WriteLine("     1. Simple Goal");
        Console.WriteLine("     2. Eternal Goal");
        Console.WriteLine("     3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        goalChoice = Console.ReadLine();
        Console.Write("What is the name of your goal?: ");
        name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        points = int.Parse(Console.ReadLine());

        if (goalChoice == "1")
        {
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
        }
        else if (goalChoice == "2")
        {

        }
        else if (goalChoice == "3")
        {

        }
        else
        {
            Console.WriteLine("Not a valid option");
        }

    }

    public void RecordEvent()
    {
        int goalIndex;
        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        goalIndex = int.Parse(Console.ReadLine());
        if (goalIndex > 0 && goalIndex < _goals.Count + 1)
        {
            int points = _goals[goalIndex - 1].RecordEvent();
            _score += points;
            Console.WriteLine($"Congratulations! You have earned {points} points!");
            Console.WriteLine($"You now have {_score} points.");
        }
        else
        {
            Console.WriteLine("Not a valid option");
        }
    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {

    }
}
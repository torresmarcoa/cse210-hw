using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Runtime;
using System.Runtime.Serialization;

public class GoalManager
{
    // Variable to store the User's Goals, score and levels
    private List<Goal> _goals;
    private int _score;
    private Levels _levels;

    // Constructor that initializes the Goal manager with default values
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _levels = new Levels();
    }

    // Method that start the whole program
    public void Start()
    {
        string choice;

        // Menu
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
    // Method to display player's score and level
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
        _levels.GetDetails();
    }

    // Method to list the names of all goals
    public void ListGoalNames()
    {
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetName()}");
            i++;
        }
    }

    // Method to list details of all goals
    public void ListGoalDetails()
    {
        int i = 1;
        foreach (Goal goal in _goals)
        {

            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
            i++;
        }
    }

    // Method to create a new goal
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
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }
        else if (goalChoice == "3")
        {
            int target;
            int bonus;
            Console.Write("How many times does this goal need to be acomplished for a bonus? ");
            target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            bonus = int.Parse(Console.ReadLine());
            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
        }
        else
        {
            Console.WriteLine("Not a valid option");
        }

    }


    // Method to record goal accomplishment
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
            _levels.AddPoints(points);
            Console.WriteLine($"Congratulations! You have earned {points} points!");
            Console.WriteLine($"You now have {_score} points.");
        }
        else
        {
            Console.WriteLine("Not a valid option");
        }
    }

    // Method to save goals to a file
    public void SaveGoals()
    {
        string fileName;
        Console.Write("What is the filename for the goal file? ");
        fileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine(_score);
            writer.WriteLine(_levels.GetStringRepresentation());
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved.");
    }

    // Method to load goals from a file
    public void LoadGoals()
    {
        string fileName;
        Console.Write("What is the filename for the goal file? ");
        fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                _score = int.Parse(reader.ReadLine());
                _goals.Clear();
                string line;

                // Load level information
                _levels = Levels.FromStringRepresentation(reader.ReadLine());

                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split("|");

                    if (parts[0] == "SimpleGoal")
                    {
                        _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
                    }
                    else if (parts[0] == "EternalGoal")
                    {
                        _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                    }
                    else if (parts[0] == "ChecklistGoal")
                    {
                        _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
                    }
                }

            }
        }
        else
        {
            Console.WriteLine($"The file {fileName} does not exist.");
        }
    }
}
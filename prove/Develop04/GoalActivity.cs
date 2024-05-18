using System;
using System.Data.Common;
using System.Dynamic;

public class GoalActivity : Activity
{
    // List of prompts to help users brainstorm goals
    private List<string> _prompts = new List<string>{
        "Think about your career. What goals would you like to set?",
        "Think about your physical health. What goals would you like to set?",
        "Think about your finances. What goals would you like to set?",
        "Think about your personal relations. What goals would you like to set?"
    };

    // List to store user goals
    private List<string> _goals = new List<string>();
   
    // Constructor that initializes the name and description of the activity
    public GoalActivity()
    {
        _name = "Goal Setting";
        _description = "This activity will help you reflect on some aspects of your life and brainstorm goals for different the areas.";
    }

    // Method to run the activity
    public void Run()
    {
        string choice;

        DisplayStartingMessage();

        // Loop to display menu options until the user chooses to end the activity
        do
        {
            Console.WriteLine("Activity menu");
            Console.WriteLine("     Select 1 to start brainstorming some goals");
            Console.WriteLine("     Select 2 to load and display a previous list of goals if present");
            Console.WriteLine("     Select 3 to end activity");
            Console.Write("Select one option from the menu: ");
            Console.WriteLine();

            choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("List as many goals you can think of the following prompt");
                Console.WriteLine($"____ {GetRandomPrompt()} ____");
                Console.Write("You may begin in: ");
                ShowCountDown(5);
                Console.WriteLine();

                _goals = GetGoalsFromUser();

                ShowGoalsList();

                CreateDocument();

                break;
            }
            else if (choice == "2")
            {
                LoadGoalsFromDocument();
                Console.Write("Loading previous goals ");
                ShowSpinner(3);
                Console.WriteLine();
                ShowGoalsList();
            }
            else if (choice == "3")
            {
                break;
            }

        }
        while (choice != "3");

        DisplayEndingMessage();

        Console.Clear();
    }
    
    // Method to get a random prompt from the list of prompts
    public string GetRandomPrompt()
    {
        Random random = new Random();

        int randomIndex = random.Next(0, _prompts.Count);


        return _prompts[randomIndex];
    }

    // Method to get goals from the user within the specified duration
    public List<string> GetGoalsFromUser()
    {
        List<string> goals = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        do
        {
            Console.Write("> ");
            goals.Add(Console.ReadLine());
        }
        while (DateTime.Now < endTime);

        return goals;
    }

    // Method to create a document and save the list of goals
    public void CreateDocument()
    {
        string fileName = "goals.csv";
        using (StreamWriter outputFile = new StreamWriter(fileName, append: true))
        {
            foreach (string goal in _goals)
            {
                string goals = goal.Contains(",") ? $"\"{goal}\"" : goal;
                outputFile.WriteLine(goals);
            }
        }
    }

    // Method to load goals from the document
    public void LoadGoalsFromDocument()
    {
        string fileName = "goals.csv";
        if (File.Exists(fileName))
        {
            _goals.Clear();
            using (StreamReader inputFile = new StreamReader(fileName))
            {
                string line;
                while ((line = inputFile.ReadLine()) != null)
                {
                    _goals.Add(line);
                }
            }
        }
        else
        {
            Console.WriteLine($"File {fileName} does not exist yet.");
        }
    }

    // Method to display the list of goals
    public void ShowGoalsList()
    {
        if (_goals.Count > 0)
        {
            Console.WriteLine("Great! Here is a list of your goals:");
            foreach (string goal in _goals)
            {
                Console.WriteLine(goal);
            }
            ShowSpinner(8);
        }
        else
        {
            Console.WriteLine("No goals to display.");
        }
    }
}
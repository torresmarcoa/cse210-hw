using System;

class Program
{
    // I added a new activity called Goal Activity, this activity helps the 
    // user to brainstorm some goals and store them in a file called goals.csv
    // That file can be load by the program, and previous goals can be seen
    // the program does not delete the previous goals
    static void Main(string[] args)
    {
        string choice;

        // Loop to display the menu until the user chooses to quit
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1. Start breathing activity");
            Console.WriteLine("     2. Start reflecting activity");
            Console.WriteLine("     3. Start listing activity");
            Console.WriteLine("     4. Start goals activity");
            Console.WriteLine("     5. Quit");

            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if (choice == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            else if (choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
            else if (choice == "4")
            {
                GoalActivity goalActivity = new GoalActivity();
                goalActivity.Run();
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye");
            }
            
        }
        while (choice != "5");
    }
}
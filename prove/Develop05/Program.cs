using System;

class Program
{
    // Added the Levels class. This class assigns a level to the user based on their points.
    // It displays the current level and the points needed to reach the next level.

    static void Main(string[] args)
    {
        // Creates the goalmanager object and start the program
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}
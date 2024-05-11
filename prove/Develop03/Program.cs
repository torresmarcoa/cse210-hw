using System;
using System.Security.Cryptography.X509Certificates;

class Program
{

    // This program exceeds the requirements by adding an option to restart the program after all the words are hidden.
    // It uses a nested do-while loop structure where the outer loop controls the program's execution, 
    // and the inner loop handles displaying the scripture text and processing user input.
    // Also, the program is designed to not repeat any hidden word, so it will always hide another word.

    static void Main(string[] args)
    {
        // Outer do-while loop to control the program's execution, it keeps running untill the 
        // user decides to quit (break the loop)

        do
        {
            // Variable that stores the user's choice
            string choice;
            // Reference object initialized and reference construct called
            Reference reference = new Reference("Alma", 37, 37);
            // Scripture object initialized and scripture reference called
            Scripture scripture = new Scripture(reference, "Counsel with the Lord in all thy doings, and he will direct thee for good; yea, when thou liest down at night lie down unto the Lord, that he may watch over you in your sleep; and when thou risest in the morning let thy heart be full of thanks unto God; and if ye do these things, ye shall be lifted up at the last day.");

            // Inner do-while loop to display the scripture text and handle user input
            do
            {
                // Clears the console each time the loop is initialized
                Console.Clear();
                // Displays the scripture text and adds an space to receive the user input
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();
                // Prompts the user to continue or quit
                Console.WriteLine("Press enter to continue or type 'quit' to finish.");
                choice = Console.ReadLine();

                // If all the words are hidden breaks the loop
                if (scripture.IscompletelyHidden())
                {
                    Console.Clear();
                    Console.WriteLine(scripture.GetDisplayText());
                    Console.WriteLine();
                    break;
                }
            } while (choice != "quit");

            // If the user does nor type quit the program will propmpt if the user wants to restart the program
            if (choice != "quit")
            {
                Console.WriteLine("Would you like to start again the program? (Press enter to close, type 'y' to restart the program)");
                string restart = Console.ReadLine();

                // If the user doesn't want to restart, break the outer loop
                if (restart != "y")
                {
                    break;
                }
            }
            else
            {
                break;
            }

        } while (true);

    }
}
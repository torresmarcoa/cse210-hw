using System;

class Program
{
    static void Main(string[] args)
    {
        //displays a welcome message to the user calling the function
        DisplayWelcome();

        //stores the results of the user name and user number in separate variables for latter use
        string name = PromptUserName();
        int number = PromptUserNumber();

        //stores the result of squaring the user number in a variable for use
        int squaredNumber = SquareNumber(number);

        //calls the function with the user name and squared number
        DisplayResult(name, squaredNumber);

        //function to displays a welcome message
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        //function that asks the user for their name and return it
        static string PromptUserName()
        {
            Console.Write("Please enrter your name: ");
            string userName = Console.ReadLine();

            return userName;
        }

        //function that asks for the user favorite number and return it
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int favoriteNumber = int.Parse(Console.ReadLine());
            return favoriteNumber;
        } 

        //function that squares the user number and returns the result 
        static int SquareNumber(int number)
        {
            int square = number * number;
            
            return square;
        }

        //function that displays the user name and squared number of the user's favorite number
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        } 
    }
}
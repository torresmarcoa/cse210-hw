using System;

class Program
{
    static void Main(string[] args)
    {
        //Ask the student for his first name and store it in a variable called firstName
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        //Ask the student for his last name and store it in a variable called lastName
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        
        //Add a space
        Console.WriteLine("");

        //Prints the student's name
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}
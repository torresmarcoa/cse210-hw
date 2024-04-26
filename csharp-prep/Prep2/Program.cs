using System;

class Program
{
    static void Main(string[] args)
    {
        //Creates a string variable named letter and assingned it no value
        string letter = "";

        //Prompts the ustudents for their grade percentage and store it in a string variable 
        Console.Write("What is your grade percentage (do not include the % symbol)? ");
        string gradePercentageString = Console.ReadLine();

        //changes the string variable to a new int variable
        int gradePercentageInt = int.Parse(gradePercentageString);

        //If block to determine the students' grade letter
        if (gradePercentageInt >= 90)
        {
            letter = "A";
        }
        else if (gradePercentageInt >= 80)
        {
            letter = "B";
        }
        else if (gradePercentageInt >= 70)
        {
            letter = "C";
        }
        else if (gradePercentageInt >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        //displays the students grade letter
        Console.WriteLine($"Your grade is {letter}.");

        //If block to determine if the student pass the class
        if (gradePercentageInt >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course!!");
        }
        else 
        {
            Console.WriteLine("Sorry you didn't pass the course, but you can do it better next time!");
        }
    }
}
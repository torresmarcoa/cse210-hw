using System;

class Program
{
    static void Main(string[] args)
    {
        string choice; 

        Reference reference = new Reference("1 Nephi", 1,1);
        Scripture scripture = new Scripture(reference, "I will go and do");

        do
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            choice = Console.ReadLine();
        } 
        while (choice != "quit");
    }
}
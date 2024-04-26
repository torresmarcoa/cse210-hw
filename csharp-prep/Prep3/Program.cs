using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {   
        //randoms generate a number and store the random generated number in the variable magicNumber
        Random randomNumberGenerator = new Random();
        int magicNumber = randomNumberGenerator.Next(1, 101);
        
        // Initialize the guessNumber variable to -1, which will be used to store the user's guessed number.
        int guessNumber = -1;

        while (guessNumber != magicNumber)
        {
            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());

            if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNumber == magicNumber)
            {
                Console.WriteLine("You guess it");
            }
        }


    }
}
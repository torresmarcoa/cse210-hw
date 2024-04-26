using System;
using System.Collections.Generic;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        //creates a list of numbers 
        List<int> numbers = new List<int>();

        //displays the first message
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        //initialize the variable unerNumber for the loop which will be used to store the User Number
        int userNumber = -1;

        //initialize the variable sum that will hold the sum of the numbers in the list
        int sum = 0;

        //do - while loop that will keep adding numbers untill the user puts a 0
        do
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            //only add numbers to the list if they are not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
            
        } while (userNumber != 0);


        //forech loop that will sum each number in the list of numbers
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        //initialize the average variable as a double and divides the sum by the quantity of numbers the list has
        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //Initialize a variable named maxNumber to store the maximum number found so far, 
        //assuming that the first element of the array is the maximum
        int maxNumber = numbers[0];

        //foreach loop that will iterate through each element of the array and determine the maximun number
        foreach (int number in numbers)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }
        //displays the maximum number in the list
        Console.WriteLine($"The largest number is: {maxNumber}");
    }
}
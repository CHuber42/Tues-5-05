using System;

class highlow{
    static void Main()
    {
        Random rand = new Random();
        int winNumber = rand.Next(100);
        int userGuess = -1;
        Console.WriteLine("I am thinking of a number between 1 and 100. Please choose a number and I will tell you if my number is higher or lower than that.");

        while (userGuess != winNumber)
        {
            string userGuessInput = Console.ReadLine();
            userGuess = int.Parse(userGuessInput);

            if (userGuess > winNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (userGuess < winNumber)
            {
                Console.WriteLine("Higher");
            }
            else {
                Console.WriteLine("Correct! You Win!");
            }
        }
    }
}
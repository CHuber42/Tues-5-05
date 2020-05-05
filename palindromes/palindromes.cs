using System;

class Palindrome{
    static void Main()
    {
        bool palindrome = true;
        Console.WriteLine("I will take two inputs and tell you if they are palindromic.\nFirst Input:");
        string userInput1 = Console.ReadLine();
        Console.WriteLine("Second Input:");
        string userInput2 = Console.ReadLine();

        if (userInput1.Length != userInput2.Length)
        {
            palindrome = false;
        }
        
        for (int i = 0; i < userInput1.Length; i++)
        {
            if (palindrome) 
            {
                if (userInput1[i] != userInput2[userInput2.Length - 1 - i])
                {
                    palindrome = false;
                }
            }
        }
    
    if (palindrome)
    {
        Console.WriteLine("Your inputs are palindromic!");
    }
    else
    {
        Console.WriteLine("Your inputs are not palindromic!");
    }

    }
}
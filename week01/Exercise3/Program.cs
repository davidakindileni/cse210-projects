/*
BYU-Pathway CS210 - Programming with Classes | 25T5 | Waldyr Junior
Author: Akinsola David Akindileni
W01 Exercise 3 Assignment
    
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        // Clear the console
        Console.Clear();

        string playAgain = "yes";
        // loop to allow multiple games
        do
        {
            string doGuess = "yes";
            // generate the random number
            int magicNumber = new Random().Next(1, 100);

            int numOfGuesses = 0;
            do
            {
                Console.Write("What is the guess number? : ");
                string guessNum = Console.ReadLine();
                int guessNumber = int.Parse(guessNum);

                if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Go lower");
                    numOfGuesses++;
                }
                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Go higher");
                    numOfGuesses++;
                }
                else
                {
                    numOfGuesses++;
                    Console.WriteLine();
                    Console.WriteLine($"You guessed it right in {numOfGuesses} guesses.");
                    doGuess = "no";
                }
            } while (doGuess == "yes");

            // ask to play again and only allow "yes" or "no" (any case)
            do
            {
                Console.WriteLine();
                Console.Write("Would you like to play again? (yes or no): ");
                // trim whitespace and convert to lowercase
                playAgain = Console.ReadLine().Trim().ToLower();

                // validate input
                if (playAgain != "yes" && playAgain != "no")
                {
                    Console.WriteLine("Invalid input. Please type 'yes' or 'no'.");
                }
            } while (playAgain != "yes" && playAgain != "no");

        } while (playAgain == "yes");
        Console.WriteLine();
    }
}
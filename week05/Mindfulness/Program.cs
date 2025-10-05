/*
BYU-Pathway CS210 - Programming with Classes | 25T5 | Waldyr Junior
Author: Akinsola David Akindileni
W05 Team Activity: Mindfulness Design - Main Program
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        // clear console
        Console.Clear();
        Console.Write("\n*** The Mindfulness Program ****\n");

        //call MainMenu function
        MainMenu option = new MainMenu();
        int seconds;

        int action = 0;
        while (action != 4)
        {
            // Ask for user input (1-4)
            action = option.UserChoice();
            switch (action)
            {
                case 1:
                    // Breathing Activity selected
                    Console.Clear();
                    BreathingActivity breathing = new BreathingActivity("Breathing", 0);
                    breathing.GetActivityName();
                    breathing.GetActivityDescription();
                    seconds = breathing.GetActivityTime();
                    breathing.GetReady();
                    breathing.Breathing(seconds);
                    breathing.GetDone();
                    break;
                case 2:
                    //Reflecting Activity selected
                    Console.Clear();
                    ReflectingActivity reflecting = new ReflectingActivity("Reflecting", 0);
                    reflecting.GetActivityName();
                    reflecting.GetActivityDescription();
                    seconds = reflecting.GetActivityTime();
                    reflecting.GetReady();
                    reflecting.ShowPrompt(seconds);
                    reflecting.GetDone();
                    break;
                case 3:
                    //Listing Activity selected
                    Console.Clear();
                    ListingActivity listing = new ListingActivity("Listing", 0);
                    listing.GetActivityName();
                    listing.GetActivityDescription();
                    seconds = listing.GetActivityTime();
                    listing.GetReady();
                    listing.ReturnPrompt(seconds);
                    listing.GetDone();
                    break;
                case 4:
                    // Exit the progra,
                    Console.WriteLine("\nGoodbye!\n");
                    break;
                default:
                    Console.WriteLine($"\nInvalid option.");
                    break;
            }
        }
    }
}
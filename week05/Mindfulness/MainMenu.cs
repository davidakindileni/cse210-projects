/*
BYU-Pathway CS210 - Programming with Classes | 25T5 | Waldyr Junior
Author: Akinsola David Akindileni
W05 Team Activity: Mindfulness Design - Main Menu
*/

using System;

public class MainMenu
{
    // define member variables
    private string _menu = $@"
Main Menu
=========
Please select one of the following options:

1. Breathing activity
2. Reflecting activity
3. Listing activity
4. Exit

Enter your option:  ";

    public string _userInput;
    private int _userChoice = 0;

    // define functions
    public int UserChoice()
    // display main menu
    {
        // clear console
        Console.Clear();
        Console.Write(_menu);

        _userInput = Console.ReadLine();
        _userChoice = 0;
        // validate user's entry
        try
        {
            _userChoice = int.Parse(_userInput);
        }
        catch (FormatException)
        {
            _userChoice = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Unexpected error:  {exception.Message}");
        }
        return _userChoice;
    }
}
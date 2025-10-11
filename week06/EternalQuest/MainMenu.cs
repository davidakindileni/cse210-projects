/*
BYU-Pathway CS210 - Programming with Classes | 25T5 | Waldyr Junior
Author: Akinsola David Akindileni
W06 Project: Eternal Quest Program - Main Menu Class
*/

using System;

public class MainMenu
{
    // define member variables
    private string _menu = $@"
Main Menu
===========================================
Options:
1. Create New Goal
2. List Goals
3. Save Goals
4. Load Goals
5. Record Goal Event
6. Quit
===========================================
Enter your choice:  ";

    public string _userInput;
    private int _userChoice = 0;

    // define methods
    public int UserChoice()
    // Method to display choices to user
    {
        Console.Write(_menu);

        _userInput = Console.ReadLine();
        _userChoice = 0;
        // This block catches any non integer values that are entered
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
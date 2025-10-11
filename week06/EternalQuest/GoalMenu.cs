/*
BYU-Pathway CS210 - Programming with Classes | 25T5 | Waldyr Junior
Author: Akinsola David Akindileni
W06 Project: Eternal Quest Program - Goal Menu Class
*/

using System;

public class GoalMenu
{
    // define member variables
    private string _menu = $@"
Goal Menu 
===========================================

Goal Types:
1. Simple Goal
2. Eternal Goal
3. Checklist Goal
4. Bad Habit Goal
5. Back to Main Menu

===========================================
Select the type of goal you would like to create?  ";

    public string _goalInput;
    private int _goalChoice = 0;

    // define methods
    public int GoalChoice()
    // Method to display choices to user
    {

        Console.Write(_menu);

        _goalInput = Console.ReadLine();
        _goalChoice = 0;
        // This block catches any non integer values that are entered
        try
        {
            _goalChoice = int.Parse(_goalInput);
        }
        catch (FormatException)
        {
            _goalChoice = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Unexpected error:  {exception.Message}");
        }
        return _goalChoice;
    }
}
/*
BYU-Pathway CS210 - Programming with Classes | 25T5 | Waldyr Junior
Author: Akinsola David Akindileni
W06 Project: Eternal Quest Program - Simple Goal Class
*/

using System;

public class SimpleGoal : Goal
{
    // define member variables
    private string _type = "Simple Goal:";
    private bool _status;

    // define constructors
    public SimpleGoal(string type, string name, string desc, int points) : base(type, name, desc, points)
    {
        _status = false;
    }
    public SimpleGoal(string type, string name, string desc, int points, bool status) : base(type, name, desc, points)
    {
        _status = status;
    }
    public Boolean Finished()
    {
        return _status;
    }

    // define methods
    public override void ListGoal(int i)
    {
        if (Finished() == false)
        {
            Console.WriteLine($"{i}. [ ] {GetName()} ({GetDesc()})");
        }
        else if (Finished() == true)
        {
            Console.WriteLine($"{i}. [X] {GetName()} ({GetDesc()})");
        }
    }
    public override string SaveGoal()
    {
        return ($"{_type}; {GetName()}; {GetDesc()}; {GetPoints()}; {_status}");
    }
    public override string LoadGoal()
    {
        return ($"{_type}; {GetName()}; {GetDesc()}; {GetPoints()}; {_status}");
    }
    public override void RecordGoalEvent(List<Goal> goals)
    {
        _status = true;
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
    }
}
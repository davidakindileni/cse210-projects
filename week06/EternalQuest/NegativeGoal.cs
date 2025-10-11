/*
BYU-Pathway CS210 - Programming with Classes | 25T5 | Waldyr Junior
Author: Akinsola David Akindileni
W06 Project: Eternal Quest Program - Negative Goal Class
*/

using System;

public class NegativeGoal : Goal
{
    // define member variables
    private string _type = "Negative Goal:";
    private bool _status;

    // define constructors
    public NegativeGoal(string type, string name, string desc, int points) : base(type, name, desc, points)
    {
        _status = false;
    }
    public NegativeGoal(string type, string name, string desc, int points, bool status) : base(type, name, desc, points)
    {
        _status = status;
    }

    // define methods
    public override void ListGoal(int i)
    {
        Console.WriteLine($"{i}. [ ] {GetName()} ({GetDesc()})");
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
        Console.WriteLine($"Bummer! You have Lost {GetPoints()} points!");
    }
}
/*
BYU-Pathway CS210 - Programming with Classes | 25T5 | Waldyr Junior
Author: Akinsola David Akindileni
W06 Project: Eternal Quest Program - Eternal Goal Class
*/

using System;

public class EternalGoal : Goal
{
    // define member variable
    private string _type = "Eternal Goal:";
    private bool _status;


    // define constructors
    public EternalGoal(string type, string name, string desc, int points) : base(type, name, desc, points)
    {
        _status = false;
    }
    public EternalGoal(string type, string name, string desc, int points, bool status) : base(type, name, desc, points)
    {
        _status = status;
    }

    // defone methods

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
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
    }


}
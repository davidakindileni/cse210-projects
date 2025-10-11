/*
BYU-Pathway CS210 - Programming with Classes | 25T5 | Waldyr Junior
Author: Akinsola David Akindileni
W07 Assignment: Exercise Tracking Program | Activity Class
*/

using System;

using System;

public abstract class Activity
{
    private string _date { get; set; }
    private double _length { get; set; }

    public Activity(double length)
    {
        _length = length;
    }

    public string GetDate()
    {
        DateTime date = DateTime.Now;
        string _date = date.ToString("dd MMM yyyy");
        return _date;
    }

    public double GetLength()
    {
        return _length;
    }

    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();
    public abstract void DisplaySummary();
}
/*
BYU-Pathway CS210 - Programming with Classes | 25T5 | Waldyr Junior
Author: Akinsola David Akindileni
W07 Assignment: Exercise Tracking Program | Cycling Class
*/

using System;

public class Cycling : Activity
{
    private double _speed { get; set; }

    public Cycling(double length, double speed) : base(length)
    {
        _speed = speed;
    }

    public override double CalculateDistance()
    {
        double distance = Math.Round(GetLength() * CalculateSpeed() / 60, 1);
        return distance;
    }

    public override double CalculateSpeed()
    {
        return Math.Round(_speed, 1);
    }

    public override double CalculatePace()
    {
        double pace = Math.Round(60 / CalculateSpeed(), 1);
        return pace;
    }

    public override void DisplaySummary()
    {
        Console.WriteLine($"{GetDate()} Cycling ({GetLength()} min) - Distance: {CalculateDistance()} miles, Speed: {CalculateSpeed()}, Pace: {CalculatePace()} min per mile");
    }
}
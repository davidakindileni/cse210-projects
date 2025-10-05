/*
BYU-Pathway CS210 - Programming with Classes | 25T5 | Waldyr Junior
Author: Akinsola David Akindileni
W05 Team Activity: Mindfulness Design - Activity Class
*/

using System;

public class Activity
{
    // define member variables
    private string _activityName;
    private int _activityTime;
    private string _message = "You may begin in...";

    // define constructor
    public Activity(string activityName, int activityTime)
    {
        _activityName = activityName;
        _activityTime = activityTime;
    }

    // define getters and setters
    public void GetActivityName()
    {
        Console.WriteLine($"Welcome to the {_activityName} Activity\n");
    }
    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }
    public int GetActivityTime()
    {
        Console.Write("\nHow many seconds would you like for your session? ");
        int userSeconds = Int32.Parse(Console.ReadLine());
        _activityTime = userSeconds;
        return userSeconds;
    }
    public void SetActivityTime(int activityTime)
    {
        _activityTime = activityTime;
    }

    // define functions
    public void GetReady()
    {
        Console.Clear();
        Spinner spinner = new Spinner();
        spinner.ShowSpinnerReady();
    }

    public void GetDone()
    {
        Spinner spinner = new Spinner();
        spinner.ShowSpinnerDone();
        Console.WriteLine($"\nYou have completed another {_activityTime} seconds of the {_activityName} Activity!");
        spinner.ShowSpinner();
    }
    public void CountDown(int time)
    {
        // blank line
        Console.WriteLine();
        for (int i = time; i > 0; i--)
        {
            Console.Write($"{_message}{i}");
            Thread.Sleep(1000);
            // overwrite the line
            string blank = new string('\b', (_message.Length + 5));
            Console.Write(blank);
        }

        Console.WriteLine($"Go:                                  ");
    }
}
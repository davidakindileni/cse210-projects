/*
BYU-Pathway CS210 - Programming with Classes | 25T5 | Waldyr Junior
Author: Akinsola David Akindileni
W05 Team Activity: Mindfulness Design - Breathing Activity Class
*/

using System;

public class BreathingActivity : Activity
{
    // define member variables
    private string _msg1 = "Breathe in...";
    private string _msg2 = "Now breathe out...";
    private string _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    // define constructor
    public BreathingActivity(string activityName, int activityTime) : base(activityName, activityTime)
    {

    }

    // define functions
    public void GetActivityDescription()
    {
        Console.WriteLine(_description);
    }

    public void Breathing(int seconds)
    {
        Console.WriteLine();
        int secondsTimer = 0;
        while (secondsTimer < seconds)
        {
            Console.WriteLine();
            for (int i = 4; i > 0; i--)
            {
                Console.Write($"{_msg1}{i}");
                Thread.Sleep(1000);
                string blank = new string('\b', (_msg1.Length + 2));
                Console.Write(blank);
                secondsTimer += 1;
            }
            Console.WriteLine($"{_msg1}  ");
            for (int i = 5; i > 0; i--)
            {
                Console.Write($"{_msg2}{i}");
                Thread.Sleep(1000);
                string blank = new string('\b', (_msg2.Length + 2));
                Console.Write(blank);
                secondsTimer += 1;
            }
            Console.WriteLine($"{_msg2}  ");
        }
    }
}
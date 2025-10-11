/*
BYU-Pathway CS210 - Programming with Classes | 25T5 | Waldyr Junior
Author: Akinsola David Akindileni
W07 Assignment: Exercise Tracking Program | Program Class
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activitiesList = new List<Activity>();

        Running running = new Running(15, 4);
        activitiesList.Add(running);
        Cycling cycling = new Cycling(25, 12);
        activitiesList.Add(cycling);
        Swimming swimming = new Swimming(40, 70);
        activitiesList.Add(swimming);


        //display activity summaries
        foreach (Activity activity in activitiesList)
        {
            activity.DisplaySummary();
        }
    }
}
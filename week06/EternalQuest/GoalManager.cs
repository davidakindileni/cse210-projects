/*
BYU-Pathway CS210 - Programming with Classes | 25T5 | Waldyr Junior
Author: Akinsola David Akindileni
W06 Project: Eternal Quest Program -  Goal Manager Class
*/

using System;
using System.IO;

public class GoalManager

{
    // define member variable
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints;


    // define constructors
    public GoalManager()
    {
        _totalPoints = 0;
    }
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public int GetTotalPoints()
    {
        return _totalPoints;
    }
    public void AddPoints(int points)
    {
        _totalPoints += points;
    }
    public void SetTotalPoints(int totalPoints)
    {
        _totalPoints = totalPoints;
    }
    public List<Goal> GetGoalsList()
    {
        return _goals;
    }

    // define methods
    public void ListGoals()
    {
        if (_goals.Count() > 0)
        {
            Console.WriteLine("\nYour Goals are:");

            int index = 1;
            // Loop though goals list
            foreach (Goal goal in _goals)
            {
                goal.ListGoal(index);
                index = index + 1;
            }
        }
        else
        {
            Console.WriteLine("\nYou currently have no goals!");
        }
    }
    public void RecordGoalEvent()
    {
        ListGoals();

        Console.Write("\nWhich goal did you accomplished?  ");
        int select = int.Parse(Console.ReadLine()) - 1;

        int goalPoints = GetGoalsList()[select].GetPoints();
        AddPoints(goalPoints);

        GetGoalsList()[select].RecordGoalEvent(_goals);

        Console.WriteLine($"\n*** You have {GetTotalPoints()} points! ***\n");
    }
    public void SaveGoals()
    {
        Console.Write("\nWhat is the name for your goal text file? (do not add the file extension): ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        using (StreamWriter outputFile = new StreamWriter(userFileName))
        {
            // Save Total Points
            outputFile.WriteLine(GetTotalPoints());
            // Save goals list
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("\nWhat is the name for your goal text file? (do not add the file extension): ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        if (File.Exists(userFileName))
        {
            string[] readText = File.ReadAllLines(userFileName);

            // read the first line of text file for total stored points
            int totalPoints = int.Parse(readText[0]);
            SetTotalPoints(totalPoints);
            // skip the first line of text file to read to goals
            readText = readText.Skip(1).ToArray();
            // loop though text file for goals
            foreach (string line in readText)
            {
                string[] entries = line.Split("; ");

                string type = entries[0];
                string name = entries[1];
                string desc = entries[2];
                int points = int.Parse(entries[3]);
                bool status = Convert.ToBoolean(entries[4]);

                if (entries[0] == "Simple Goal:")
                {
                    SimpleGoal sGoal = new SimpleGoal(type, name, desc, points, status);
                    AddGoal(sGoal);
                }
                if (entries[0] == "Eternal Goal:")
                {
                    EternalGoal eGoal = new EternalGoal(type, name, desc, points, status);
                    AddGoal(eGoal);
                }
                if (entries[0] == "Check List Goal:")
                {
                    int numberTimes = int.Parse(entries[5]);
                    int bonusPoints = int.Parse(entries[6]);
                    int counter = int.Parse(entries[7]);
                    ChecklistGoal clGoal = new ChecklistGoal(type, name, desc, points, status, numberTimes, bonusPoints, counter);
                    AddGoal(clGoal);
                }
                if (entries[0] == "Negative Goal:")
                {
                    NegativeGoal nGoal = new NegativeGoal(type, name, desc, points, status);
                    AddGoal(nGoal);
                }
            }
        }
    }
}
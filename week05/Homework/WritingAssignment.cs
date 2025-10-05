/*
BYU-Pathway CS210 - Programming with Classes | 25T5 | Waldyr Junior
Author: Akinsola David Akindileni
W05 Assignment: Writing Assignment Class
*/

using System;

public class WritingAssignment : Assignment
{
    // define the member variables
    private string _title;

    // create the MathAssignment constructors
    public WritingAssignment()
    {

    }

    public WritingAssignment(string stuName, string topic, string title)
        : base(stuName, topic)
    {
        _title = title;
    }

    // create the getters and setters
    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    // define the function
    public string GetWritingInfo()
    {
        string stuName = GetStudentName();
        return $"{_title} by {stuName}";
    }
}
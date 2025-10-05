/*
BYU-Pathway CS210 - Programming with Classes | 25T5 | Waldyr Junior
Author: Akinsola David Akindileni
W05 Assignment: Math Assignment Class
*/

using System;

public class MathAssignment : Assignment
{
    // define the member variables
    private string _textBookSection;
    private string _problems;

    // create the MathAssignment constructors
    public MathAssignment()
    {

    }

    public MathAssignment(string stuName, string topic, string textBookSection, string problems)
        : base(stuName, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    // create the getters and setters
    public string GetTextBookSection()
    {
        return _textBookSection;
    }
    public void SetTextBookSection(string textBookSection)
    {
        _textBookSection = textBookSection;
    }
    public string GetProblems()
    {
        return _problems;
    }
    public void SetProblems(string problems)
    {
        _problems = problems;
    }

    // define the function
    public string GetHomeworkList()
    {
        return $"Section: {_textBookSection} Problems: {_problems}";
    }
}
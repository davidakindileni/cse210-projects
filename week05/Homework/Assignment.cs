/*
BYU-Pathway CS210 - Programming with Classes | 25T5 | Waldyr Junior
Author: Akinsola David Akindileni
W05 Assignment: Assignmrnt Class
*/

using System;

public class Assignment
{
    // define the member variables
    private string _stuName = "";
    private string _topic = "";

    // create the Assignment constructors
    public Assignment()
    {

    }

    public Assignment(string stuName, string topic)
    {
        _stuName = stuName;
        _topic = topic;
    }

    // create the getters and setters
    public string GetStudentName()
    {
        return _stuName;
    }
    public void SetStudentName(string stuName)
    {
        _stuName = stuName;
    }
    public string GetTopic()
    {
        return _topic;
    }
    public void SetTopic(string topic)
    {
        _topic = topic;
    }

    // define the function
    public string GetSummary()
    {
        return $"{_stuName} - {_topic}";
    }
}
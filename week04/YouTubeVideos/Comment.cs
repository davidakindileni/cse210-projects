/*
BYU-Pathway CS210 - Programming with Classes | 25T5 | Waldyr Junior
Author: Akinsola David Akindileni
W04 Assignment: YouTube Video Program - Comment Class
*/

using System;

public class Comment
{
    // Member variables
    private string _commenterName;
    private string _text;

    // Constructor
    public Comment(string commenterName, string text)
    {
        _commenterName = commenterName;
        _text = text;
    }

    // Methods to access member variables
    public string GetCommenterName()
    {
        return _commenterName;
    }

    public string GetText()
    {
        return _text;
    }
}

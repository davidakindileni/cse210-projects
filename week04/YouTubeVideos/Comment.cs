/*
BYU-Pathway CS210 - Programming with Classes | 25T5 | Waldyr Junior
Author: Akinsola David Akindileni
W04 Assignment: YouTube Video Program - Comment Class
    
*/

using System;
using System.Collections.Generic;  // Needed for using List<T>

// =======================
// Class representing a Comment
// =======================

public class Comment
{
    // Properties: the name of the commenter and their comment text
    public string _commenterName { get; set; }
    public string _text { get; set; }

    // Constructor to initialize a comment when created
    public Comment(string commenterName, string text)
    {
        _commenterName = commenterName;
        _text = text;
    }
}

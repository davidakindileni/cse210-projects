/*
BYU-Pathway CS210 - Programming with Classes | 25T5 | Waldyr Junior
Author: Akinsola David Akindileni
W04 Assignment: YouTube Video Program - Video Class
    
*/

using System;
using System.Collections.Generic;  // Needed for using List<T>

// =======================
// Class representing a Video
// =======================
class Video
{
    // Properties for video details
    public string _title { get; set; }
    public string _author { get; set; }
    public int _lengthInSeconds { get; set; }

    // A video has a list of comments
    private List<Comment> _comments = new List<Comment>();

    // Constructor to initialize a video when created
    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
    }

    // Method to add a comment to this video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method to return the number of comments
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Method to display all details of the video, including comments
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthInSeconds} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");

        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($" - {comment._commenterName}: {comment._text}");
        }

        Console.WriteLine(new string('-', 40)); // Separator line for readability
    }
}

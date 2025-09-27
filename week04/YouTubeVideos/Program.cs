/*
BYU-Pathway CS210 - Programming with Classes | 25T5 | Waldyr Junior
Author: Akinsola David Akindileni
W04 SAssignment: YouTube Video Program
    
*/

using System;
using System.Collections.Generic;  // Needed for using List<T>

namespace YouTubeVideos
{
    // =======================
    // Class representing a Comment
    // =======================
    class Comment
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

    // =======================
    // Main Program
    // =======================
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list to hold multiple videos
            List<Video> videos = new List<Video>();

            // -------- Video 1 --------
            Video video1 = new Video("Learning C# Basics", "John Doe", 600);
            video1.AddComment(new Comment("Alice", "This was really helpful!"));
            video1.AddComment(new Comment("Bob", "Thanks for explaining variables so clearly."));
            video1.AddComment(new Comment("Charlie", "Looking forward to the next tutorial."));
            videos.Add(video1);

            // -------- Video 2 --------
            Video video2 = new Video("Cooking Pasta the Italian Way", "Chef Mario", 900);
            video2.AddComment(new Comment("Daisy", "I tried this recipe and it was delicious!"));
            video2.AddComment(new Comment("Ethan", "Can you do a version with gluten-free pasta?"));
            video2.AddComment(new Comment("Fiona", "Love the tips about sauce preparation."));
            videos.Add(video2);

            // -------- Video 3 --------
            Video video3 = new Video("Top 10 Travel Destinations", "GlobeTrotter", 1200);
            video3.AddComment(new Comment("George", "I’ve been to 3 of these places, amazing!"));
            video3.AddComment(new Comment("Hannah", "Adding Bali to my bucket list."));
            video3.AddComment(new Comment("Ian", "Great recommendations, thank you!"));
            videos.Add(video3);

            // -------- Video 4 --------
            Video video4 = new Video("Beginner's Guide to Yoga", "Sophia Wellness", 750);
            video4.AddComment(new Comment("Jack", "This routine is so relaxing."));
            video4.AddComment(new Comment("Kate", "Perfect for my morning exercises."));
            video4.AddComment(new Comment("Leo", "Thanks for making yoga easy to follow!"));
            videos.Add(video4);

            // =======================
            // Display all videos and their comments
            // =======================
            foreach (Video video in videos)
            {
                video.DisplayVideoInfo();
            }

            // Pause so console window stays open (optional)
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
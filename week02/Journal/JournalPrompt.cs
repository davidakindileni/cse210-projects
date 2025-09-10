/*
BYU-Pathway CS210 - Programming with Classes | 25T5 | Waldyr Junior
Author: Akinsola David Akindileni
W02 JournalPrompt class
    
*/
using System;

public class JrnlPrompt
{

    public static string[] _prompt = {
        "Who was the most interesting person you interacted with today?",
        "What was the best part of your day?",
        "How did you see the hand of the Lord in your life today?",
        "What was the strongest emotion you felt today?",
        "If you had one thing you could do over today, what would it be?",
        "What new goals are you planning on setting as a result of today's activities?",
        "What insights did you gain from studying the Gospel today?",
        "What impressions came into your mind as you prayed?",
        "What good counsel did you give someone today?",
        "Who do you feel the need to help today, tomorrow, or soon?"
    };

    public List<string> _jrnlPrompt = new List<string>(_prompt);

    public string GetPrompt()
    {
        var random = new Random();
        int index = random.Next(_jrnlPrompt.Count);
        string jrnlPrompt = _jrnlPrompt[index];
        return jrnlPrompt;
    }

}
/*
BYU-Pathway CS210 - Programming with Classes | 25T5 | Waldyr Junior
Author: Akinsola David Akindileni
W02 JournalEntry class
*/

using System;

public class JrnlEntry
{
    public string _dateTime = "";
    public string _jrnlPrompt = "";
    public string _jrnlEntry = "";

    public void Display()
    {
        Console.WriteLine($"\n\tDate: {_dateTime}");
        Console.WriteLine($"\tPrompt: {_jrnlPrompt}");
        Console.WriteLine($"\tEntry: {_jrnlEntry}");
    }
}
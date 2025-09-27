/*
BYU-Pathway CS210 - Programming with Classes | 25T5 | Waldyr Junior
Author: Akinsola David Akindileni
W03 Word class

This class is responsible for holding a scripture text, break in into words,
display it to the console, and gradually hide words as the user presses space or enter.

*/

using System;
using System.Linq;

public class Word
{
    // member variables
    public string _words = "";
    public string _ref = "";
    public string[] _result;

    // Stores the list of indices of words in the scripture verse that have been hidden
    public List<int> _hiddenWords;

    public void GetRenderedText(Scripture scripture)
    {
        var _words = scripture._scriptureText;
        _result = _words.Split(" ");
        _hiddenWords = new List<int>();
    }

    public void Show(string ref1)
    {
        _ref = ref1;
        Console.Clear();

        Console.WriteLine($"{_ref}");
        for (var i = 0; i < _result.Length; i++)
        {
            var str = _result[i];
            int len = str.Length;
            string dashedLine = new String('_', len);
            if (_hiddenWords.Contains(i))
            {
                Console.Write($"{dashedLine} ");
            }
            else
            {
                Console.Write($"{str} ");
            }
            // Console.WriteLine($"Value of i: {i}; Value of result.Length: {_result.Length}");
        }
        Console.ForegroundColor=ConsoleColor.Blue;
        Console.WriteLine();
        Console.Write("\n**** Press enter to continue or type 'quit' to end ****\n");
        // Console.Write("\n**** Press Q to Quit ****\n");
        Console.ForegroundColor=ConsoleColor.White;
    }

    public void GetReadKey()
    {
        var input = Console.ReadKey();
        if (input.Key == ConsoleKey.Spacebar || input.Key == ConsoleKey.Enter)
        {
            Get2NewHiddenWords();
        }
        else if (input.Key == ConsoleKey.Q)
        {
            Environment.Exit(0);
        }
    }
    public void Get2NewHiddenWords()
    {
        var random = new Random();
        var index1 = random.Next(_result.Length);
        var index2 = random.Next(_result.Length);
        if (_hiddenWords.Contains(index1) || _hiddenWords.Contains(index2))
        {
            Get2NewHiddenWords();
        }
        else
        {
            _hiddenWords.Add(index1);
            _hiddenWords.Add(index2);

        }
    }
}
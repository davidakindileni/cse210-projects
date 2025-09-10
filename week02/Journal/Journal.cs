/*
BYU-Pathway CS210 - Programming with Classes | 25T5 | Waldyr Junior
Author: Akinsola David Akindileni
W02 Journal class
    
*/
using System;
using System.ComponentModel;
using System.IO;
using System.Text;

public class Jrnl
{
    public List<JrnlEntry> _jrnl = new List<JrnlEntry>();
    private string _userFileName;

    // display each journal entry
    public void Display()
    {
        if (_jrnl.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"\n\tNo journal entries to display.\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {
            Console.WriteLine("\n\t===   Your Journal Entries   ===");
            foreach (JrnlEntry jrnlEntry in _jrnl)
            {
                jrnlEntry.Display();
            }
            Console.WriteLine("\n\t===      End of Entries      ===");
        }
    }

    public void SaveJrnlFile()
    {
        if (_jrnl.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"\n\tNo journal entries to save.\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {
            Console.Write("\n\tEnter filename to save to: ");
            string userInput = Console.ReadLine();
            _userFileName = userInput + ".txt";

            if (File.Exists(_userFileName))
            {
                // Append journal entries
                using (StreamWriter outputFile = new StreamWriter(_userFileName, append: true))
                {
                    foreach (JrnlEntry jrnlEntry in _jrnl)
                    {
                        outputFile.WriteLine($"{jrnlEntry._dateTime}; {jrnlEntry._jrnlPrompt}; {jrnlEntry._jrnlEntry}");
                    }
                }
                Console.Write($"\tJournal entries have been successfully added to the {_userFileName}.\n");
                // reset journal file
                _jrnl.Clear();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"\t{_userFileName} does not exist. Create the file and save the entries (y or n)? ");
                Console.ForegroundColor = ConsoleColor.White;
                string userResp = Console.ReadLine();

                if ((userResp == "y") || (userResp == "Y"))
                {
                    using (StreamWriter outputFile = new StreamWriter(_userFileName))
                    {
                        foreach (JrnlEntry jrnlEntry in _jrnl)
                        {
                            outputFile.WriteLine($"{jrnlEntry._dateTime}; {jrnlEntry._jrnlPrompt}; {jrnlEntry._jrnlEntry}");
                        }
                    }

                    Console.Write($"\n\tCreated {_userFileName} successfully.\n");
                    Console.Write("\tJournal entries recorded.\n");
                    // reset journal file
                    _jrnl.Clear();
                }
            }
        }
    }

    public void LoadJrnlFile()
    {
        Console.Write("\n\tEnter the filename to load: ");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".txt";
        if (File.Exists(_userFileName))
        {
            if (_userFileName.Length > 0)
            {
                List<string> readText = File.ReadAllLines(_userFileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
                foreach (string line in readText)
                {
                    string[] entries = line.Split("; ");
                    JrnlEntry entry = new JrnlEntry();

                    entry._dateTime = entries[0];
                    entry._jrnlPrompt = entries[1];
                    entry._jrnlEntry = entries[2];
                    _jrnl.Add(entry);
                }
                Console.Write($"\tJournal entries from {_userFileName} have been successfully loaded.\n");
                // empty loaded file
                string sourceFile = "blank.txt";
                File.Copy(sourceFile, _userFileName, true);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"\n\t{_userFileName} is empty. Please try again.\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"\n\t{_userFileName} does not exist. Please try again.\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

}
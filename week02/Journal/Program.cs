/*
BYU-Pathway CS210 - Programming with Classes | 25T5 | Waldyr Junior
Author: Akinsola David Akindileni
W02 Journal Program
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        int action = 0;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("\n\t=== The Journal App ===");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("\n\t*** 'There shall be a record kept among you ... (D & C 21:1)' ***\n");

        // create new journal
        Jrnl jrnl = new Jrnl();
        JrnlPrompt jp = new JrnlPrompt();

        while (action != 5)
        {
            // request user input

            action = Choices();
            switch (action)
            {
                case 1:
                    // Write journal Entry
                    string dateInfo = GetTimeStamp();
                    string prompt = jp.GetPrompt();

                    // create new journal entry instance
                    JrnlEntry entry = new JrnlEntry();

                    // display journal prompt and receive entry
                    Console.Write($"\n\t{prompt}\n");
                    Console.Write("\t>>> ");
                    string userEntry = Console.ReadLine();

                    // assign entries to journal entry instance
                    entry._dateTime = dateInfo;
                    entry._jrnlPrompt = prompt;
                    entry._jrnlEntry = userEntry;

                    // add entry into journal
                    jrnl._jrnl.Add(entry);

                    break;
                case 2:
                    // Show inputted journal entries
                    jrnl.Display();

                    break;
                case 3:
                    // Load the journal file
                    jrnl.LoadJrnlFile();

                    break;
                case 4:
                    // Save the journal to a file
                    jrnl.SaveJrnlFile();

                    break;
                case 5:
                    // Exit the program
                    // check if unsaved entries exist
                    if (!(jrnl._jrnl.Count == 0))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"\tYou have unsaved journal entries. Save them before exiting (y or n)? ");
                        Console.ForegroundColor = ConsoleColor.White;
                        string userResp = Console.ReadLine();
                        if ((userResp == "y") || (userResp == "Y"))
                        {
                            jrnl.SaveJrnlFile();
                            Console.WriteLine("\n\tThank you and Goodbye!\n");
                            System.Environment.Exit(0);
                        }
                    }
                    Console.WriteLine("\n\tThank you and Goodbye!\n");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n\tInvalid Option ... Please try again.");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }
    }

    // Journal Choices Menu
    static int Choices()
    {
        string choices = @"
        Journal App Menu Options
        
        1. Write
        2. Display
        3. Load
        4. Save
        5. Quit
        
        Please enter your choice: ";
        Console.Write(choices);
        string userInput = Console.ReadLine();
        int action = 0;

        // Test the input options for validity
        try
        {
            action = int.Parse(userInput);
        }
        catch (FormatException)
        {
            action = 0;
        }
        catch (Exception exception)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\t\tUnexpected error:  {exception.Message}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        return action;
    }

    static string GetTimeStamp()
    // get the current date from the system and format it
    {
        DateTime now = DateTime.Now;
        string currDateTime = now.ToShortDateString();
        return currDateTime;
    }
    static void AddJrnlEntry()
    // Method to add entry to text file
    {
        string MyjrnlFile = "myjournal.txt";
        File.AppendAllText(MyjrnlFile, "");
    }
}

// Stretch Requirements
// 1. Display message when there is no journal entry to display.
// 2. The journal entries list is emptied when entries are saved.
// 3. When quitting, check and warn if the journal entries list is not empty. (i.e. unsaved entries)
// 4. Display message when there is no entry to save (journal entry list is empty)
// 5. Display message when the file to save to does not exist.
// 6. When a filename is entered to save to, check if it exists first. If it exists, add the entries
//    to the file. If the file does not exist, ask if to create it and add the entries.

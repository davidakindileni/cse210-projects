/*
BYU-Pathway CS210 - Programming with Classes | 25T5 | Waldyr Junior
Author: Akinsola David Akindileni
W01 Exercise 2 Assignment
    
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        // Clear the console
        Console.Clear();

        // declare letter as a string variable
        string letter;

        // request input of the grade percentage
        Console.Write("Please input your grade percentage: ");
        string grade = Console.ReadLine();

        // convert the input to an integer
        int intGrade = int.Parse(grade);

        // Core requirements #1 & #3
        // iterate to determine the letter grade
        if (intGrade >= 90)
        {
            letter = "A";
        }   else if (intGrade >= 80)
            {
                letter = "B";
            }   else if (intGrade >= 70)
                {
                    letter = "C";
                }   else if (intGrade >= 60)
                    {
                        letter = "D";
                    }
        else
        {
            letter = "F";
        }

        // Declare variables lastDigit and gradeSign
        int lastDigit;

        lastDigit = intGrade % 10;

        // Strength challenge #1, #2, and #3
        // Determine the grade sign
        string gradeSign = "";

        if (letter != "F")
        {
            if (lastDigit >= 7 && letter != "A")
                {
                    gradeSign = "+";
                }
            else if (lastDigit < 3)
                {
                    gradeSign = "-";
                }
        }
        // Core requirements #1
        // print the letter grade
        Console.WriteLine($"Your letter grade is {letter}{gradeSign}");

        // Core requirements #2
        // determine if the grade percentage passed or not and display appropriate message
        if (intGrade >= 70)
        {
            Console.WriteLine("Congratulations! You have passed!");
        }
        else
        {
            Console.WriteLine("Don't give up. Please try again. You've got this!");
        }
    }}
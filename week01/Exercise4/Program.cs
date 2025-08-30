using System;

class Program
{
    static void Main(string[] args)
    {
        // Clear the console
        Console.Clear();

        string userInput ="";
        List<int> myList;
        myList = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            userInput = Console.ReadLine();
            if (userInput != "0")
                {
                    int userInt = int.Parse(userInput);
                    myList.Add(userInt);
                }
        } while (userInput != "0");

        int listSum = myList.Sum();
        Console.WriteLine($"The sum is: {listSum}");

        double listAvg = myList.Average();
        Console.WriteLine($"The average is: {listAvg}");

        int listMax = myList.Max();
        Console.WriteLine($"The largest number is: {listMax}");

        int listMinAbvZero = myList.Where(f => f > 0).Min();
        Console.WriteLine($"The smallest positive number is: {listMinAbvZero}");

        var sortedList = myList.OrderBy(num => num);
        // display the contents of the list
        Console.WriteLine("The sorted list is:");
        foreach (int sortedNum in sortedList)
        {
            Console.WriteLine(sortedNum);
        }
    }
}
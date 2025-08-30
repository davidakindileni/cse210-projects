using System;

class Program
{
    static void Main(string[] args)
    {
        // Clear the console
        Console.Clear();

        ShowWelcome();

        string userName = InputUser();
        int userNumber = InputFavNum();

        int squaredNumber = SqrTheNum(userNumber);

        ShowResult(userName, squaredNumber);

        static void ShowWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string InputUser()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

        static int InputFavNum()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

        static int SqrTheNum(int number)
        {
            int square = number * number;
            return square;
        }

        static void ShowResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
    }
}
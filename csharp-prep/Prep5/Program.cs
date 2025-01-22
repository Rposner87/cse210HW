using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);

    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name!: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        return number * number;

    }

    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"Name {name}, Your square is {squaredNumber} ");
    }
}
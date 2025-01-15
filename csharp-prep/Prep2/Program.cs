using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        String grade = Console.ReadLine();
        int percentage = int.Parse(grade);
        
        if (percentage >= 90)
        {
            grade = "A";
        }
        else if (percentage >= 80)
        {
            grade = "B";
        }
        else if (percentage >= 70)
        {
            grade = "C";
        }
        else if (percentage >= 60)
        {
            grade = "D";
        }
        else if (percentage <= 60)
        {
            grade = "F";
        }
        Console.WriteLine($"Your grafe is {grade}");

        if (percentage >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You Fail");
        }
    }
}
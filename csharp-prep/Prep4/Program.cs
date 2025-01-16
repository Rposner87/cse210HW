using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine("Total Sum: " + sum);

        float average = (float)sum / numbers.Count;
        Console.WriteLine("average: " + average);

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        
        }
        {
            Console.WriteLine("Max" + max);
            
        }
    }
}
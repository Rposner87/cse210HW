using System;

class Program
{
    static void Main(string[] args)
    {
       //Console.Write("What is the magic number? ");
        //int Magicnumber = int.Parse(Console.ReadLine());   

        Random randomGenerator = new Random();
        int Magicnumber = randomGenerator.Next(1, 100);
        int guess = -1;
      

        while (Magicnumber != guess)
        {
       Console.WriteLine("What is your guess? ");
        guess = int.Parse(Console.ReadLine());

        if (Magicnumber == guess)
        {
            Console.WriteLine("You guessed it!");
        }
        else if (guess > Magicnumber)
        {
            Console.WriteLine("Too High");
        }
        else
        {
            Console.WriteLine("Too low!");
        }


        }
    }
}
 
using System;

class Program
{
    static void Main(string[] args)
    {
        int number =  5;
        int guess = 0;
        while (guess != number) 
        {
            Console.Write("Guess the Number:");
            string input = Console.ReadLine();
            guess = int.Parse(input);
            if (guess != number)
            {
             Console.Write("Nuh Uh");
             if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
             else
                {
                    Console.WriteLine("Higher");
                }
            }
        }
        Console.WriteLine("You Guessed it!");


    }
}
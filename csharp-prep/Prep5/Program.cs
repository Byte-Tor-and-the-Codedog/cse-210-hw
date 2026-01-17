using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("What's your favorite number?: ");
            string input = Console.ReadLine();
            int numb = int.Parse(input);
            return numb;
        }
        static int PromptUserBirthYear()
        {
            Console.Write("What is your birth year?: ");
            string input = Console.ReadLine();
            int year = int.Parse(input);
            return year;
        }
        static int SquareNumber(int foo)
        {
            return foo * foo;
        }
        static void DisplayResult(string name, int numb, int year)
        {
            Console.WriteLine($"{name}, the square of your number is {SquareNumber(numb)}.");
            Console.WriteLine($"{name}, you will turn {2026 - year} this year.");

        }
        DisplayWelcome();
        string name = PromptUserName();
        int numb = PromptUserNumber();
        int year = PromptUserBirthYear();
        DisplayResult(name, numb, year);


    }
}
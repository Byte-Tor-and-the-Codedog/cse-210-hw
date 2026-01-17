using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        int number = 9;
        List<int> list = new List<int>();
        Console.WriteLine("Enter numbers, enter 0 to finish");
        while (number != 0)
        {
            Console.Write("Go Ahead>");
            string input = Console.ReadLine();
            number = int.Parse(input);
            if (number != 0)
            {
                list.Add(number);
            }
        }
        int sum = list.Sum();
        float ave = (sum / list.Count);
        Console.WriteLine($"The sum is {sum}.");
        Console.WriteLine($"the Average is {ave}");
    }
}
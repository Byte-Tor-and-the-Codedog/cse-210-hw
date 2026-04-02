using System;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main(string[] args)
    {
        int answer = 0;
        Console.WriteLine("Hey welcome to the mindfulness portal.");
        while(answer != 4)
        {
            Console.Write("What would you like to do?\n1.Breathing Activity\n2.Reflection Activity\n3.Listing Activity\n4.Quit\n>");
            answer = int.Parse(Console.ReadLine());
            if(answer == 1)
            {
                BreathingActivity a1 = new BreathingActivity();
                a1.Breath();
            }
            else if(answer == 2)
            {
                ReflectionActivity a2 = new ReflectionActivity();
                a2.reflect();
            }
            else if(answer == 3)
            {
                ListingActivity a3 = new ListingActivity();
                a3.List();
            }
            else if(answer == 4)
            {
                Console.WriteLine("Bye");
            }
            else
            {
              Console.WriteLine("Invalid input, please put a numer 1-4.");
              Console.ReadKey(true);
              Console.Clear();
            }
            }

    }
}
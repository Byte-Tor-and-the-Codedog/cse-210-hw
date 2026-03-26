using System.Security.Cryptography.X509Certificates;

public class BreathingActivity : Activity
{
    //the inhale/exhale timers are randomized to make your breathing irregular and hopefully make you pass out
    public void Breath()
    {

        Random rnd = new Random();
        Console.WriteLine($"{_opener}");
        Console.ReadKey(true);
        Console.WriteLine($"{_description}");
        Console.Write("How long would you like to do it?\n>");
        int time = Console.Read();
        Console.ReadKey(true);
        Console.Clear();
        DateTime endTime = DateTime.Now.AddSeconds(time);
        while(DateTime.Now < endTime)
        {
        int inhaleTime = rnd.Next(1, 30);
        Console.WriteLine("Prepare to breath in:");
        Thread.Sleep(1000);
        Animate(inhaleTime);
        Console.Clear();
        int exhaleTime = rnd.Next(1, 30);
        Console.WriteLine("Prepare to breath out:");
        Thread.Sleep(1000);
        Animate(exhaleTime);
        Console.Clear();
        }
    }
    public BreathingActivity()
    {
        _opener = "Welcome to the Breathing activity!";
        _description= "You will be prompted to breath in and out alternately to help you regulate your oxygen!";
        SetFrames();
    }
}
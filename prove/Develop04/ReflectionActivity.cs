using System.Dynamic;

public class ReflectionActivity : Activity
{
    string _prompt;
    string _deeper;

    public ReflectionActivity()
    {
        _opener = "Welcome to the Reflection Activity";
        _description = "Please take a moment to reflect on the provided question, then respond to the follow up question to dig deeper.";
        GetFrames();
        GetPrompt();
        GetDeeper();
    }
    public void reflect()
    {
        Console.WriteLine(_opener);
        Console.ReadKey(true);
        Console.WriteLine(_description);
        Console.ReadKey(true);
        Console.Clear();
        Console.WriteLine(_prompt);
        Console.ReadKey(true);
        Animate(2);
        Console.Clear();
        Console.WriteLine(_deeper);
        //I added this sleep because it would skip this step and I'm not sure why.
        Thread.Sleep(1);
        Console.ReadKey(true);
        Animate(30);
        Console.Clear();
    }
    //Evil prompts
    public void GetPrompt()
    {
        Random rnd = new Random();
        List<string> prompts = new List<string>();
        prompts.Add("Why are you incapable of so many things that other people can do easily?");
        prompts.Add("Do you think your friends actually care about you?");
        prompts.Add("Have you ever done anything worthwhile in your life? Are you sure?");
        prompts.Add("Do all the people better than you also struggle with the things you do? How much of it is your problem?");
        _prompt = prompts[rnd.Next(0, prompts.Count())];
    }

    public void GetDeeper()
    {
        Random rnd = new Random();
        List<string> prompts = new List<string>();
        prompts.Add("What are all of the ways this is your fault?");
        prompts.Add("How would a better person than you answer this?");
        prompts.Add("Do you think there's anything worth doing at this point?");
        prompts.Add("What is the point of you even wasting time thinking about this?");
        _deeper = prompts[rnd.Next(0, prompts.Count())];
    }
}
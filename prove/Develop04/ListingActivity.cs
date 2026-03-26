public class ListingActivity : Activity
{
    public string _prompt;
    public void GetPrompts()
    {
        Random rnd = new Random();
        List<string> prompts = new List<string>();
        prompts.Add("Name all the things you're currently doing wrong?");
        prompts.Add("How many people do you think are doing better or are fundamentally better than you?");
        prompts.Add("What are your biggest weakness and people who don't have them?");
        prompts.Add("What are all the things you're good at? what people beat you at them? Why aren't you as good as them?");
        _prompt = prompts[rnd.Next(0, prompts.Count())];
    }
    public ListingActivity()
    {
        _opener = "Welcome to the listing activity";
        _description = "Please try to list all things in the category within the desired time.";
        GetPrompts();
    }
    public void List()
    {

        List<string> entries = new List<string>();
        Console.WriteLine(_opener);
        Console.ReadKey(true);
        Console.WriteLine(_description);
        Console.ReadKey(true);
        Console.WriteLine("How long do you want to do this?");
        int time = Console.Read();
        Console.Clear();
        DateTime endTime = DateTime.Now.AddSeconds(time);
        Console.WriteLine(_prompt);
        while(DateTime.Now < endTime)
        {
            Console.Write(">");
            entries.Add(Console.ReadLine());
        }
        Console.Clear();
        Console.WriteLine($"You wrote {entries.Count()} entries");
        Console.WriteLine("There's definitely more than that.");
        Console.ReadKey(true);
        Console.Clear();
    }
}
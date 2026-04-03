using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Prompt

{
    public string _prompttext;
    //Gives you the ability to add prompts to keep things interesting
    public void AddPrompt(string path)
    {
        using (StreamWriter outputFile = new StreamWriter(path, append: true))
                    {
                        outputFile.WriteLine(_prompttext);
                    }
    }
    private static Random random = new Random();
    //Acquiring a randomized prompt from the pool
    public static string GetPrompt(string path)
    {
        string[] allLines = File.ReadAllLines(path);
        List<string[]> promptList = new List<string[]>();
        foreach (var line in allLines)
        {
            string[] lines = line.Split('|');

            promptList.Add(lines);
        }
        string[] selectedPrompt = promptList[random.Next(promptList.Count)];
        return selectedPrompt[random.Next(selectedPrompt.Length)];
    }

}
using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    
    {
        Console.WriteLine("Welcome to the JournalHelper!");
        //text to be written to or edited
        string workingText = "";
        //variable that decides given task
        int foo = 1;
        while (foo >= 1 && foo <= 5)
        {
            Console.Write("What would you like to do?\n1.Write entry\n2.Add prompt\n3.Display\n4.Load\n5.Save\n6.Quit\n>");
            foo = int.Parse(Console.ReadLine());
            if (foo == 1)
            {
                Entry currentJournal = new Entry();
                currentJournal._date = Convert.ToString(DateTime.Now);
                currentJournal._prompt = Prompt.GetPrompt("prompts.txt");
                Console.Write($"Ok, Here goes:\n{currentJournal._prompt}\n>");
                currentJournal._text = Console.ReadLine();
                Console.Write("Are you sure y/n?>");
                string ans = Console.ReadLine();
                if (ans == "y")
                {
                    workingText += $"{currentJournal.GetJournalEntry()}";
                }
            }
            if (foo == 2)
            {
                Console.Write("What prompt would youe like to add?>");
                Prompt currentPrompt = new Prompt();
                currentPrompt._prompttext = Console.ReadLine();
                Console.Write("Are you sure y/n?>");
                string ans = Console.ReadLine();
                if (ans == "y")
                {
                    currentPrompt.AddPrompt("prompts.txt");
                }
            }
            if (foo == 3)
            {
                Console.WriteLine($"{workingText}");
            }
            if (foo == 4)
            //Allows you to see all the entries saved into the journal file and choose to add to them.
            {
                string path = "journal";
                string[] allFiles = Directory.GetFileSystemEntries(path);
                Console.WriteLine("What would you like to load");
                foreach (string entry in allFiles)
                {
                    Console.WriteLine(entry);
                }
                Console.Write(">");
                string fileToLoad = Console.ReadLine();
                if (allFiles.Contains(fileToLoad))
                {
                if (workingText == "")
                {
                    workingText = File.ReadAllText($"{fileToLoad}");
                }
                //safeguard in case some accidentally overwrites something they were working on
                else
                    {
                        Console.Write("Are you sure you want to overwrite current work y/n?>");
                        string ans = Console.ReadLine();
                        if (ans == "y")
                        {
                            workingText = File.ReadAllText($"{fileToLoad}");
                        }
                        else
                        {
                            Console.WriteLine("Ok");
                        }
                    }
                }
                //making sure the program doesn't crash if you get the name wrong
                else
                {
                    Console.WriteLine("File not found: aborted");
                }
            }
            if (foo == 5)
            {
                Console.WriteLine("Are you sure you want to save?");
                string ans = Console.ReadLine();
                if (ans == "y")
                {
                    string journalDirectory = "journal";
                    string fileName = $"{DateTime.Now:yyyy-MM-dd_hh-mm-ss-tt}.txt";
                    string destinationPath = Path.Combine(journalDirectory, fileName);
                    using (StreamWriter outputFile = new StreamWriter(destinationPath))
                    {
                        outputFile.WriteLine($"{workingText}");
                    }
                }
            }
        }

    }
}
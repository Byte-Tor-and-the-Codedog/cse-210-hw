using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        string Answer = "y";
        Scripture Proverbs12_5_7 = new Scripture();
        Proverbs12_5_7.SetScripture(Proverbs12_5_7.GetWordArray("5 The thoughts of the righteous are right, But the counsels of the wicked are deceitful. 6 The words of the wicked are, “Lie in wait for blood,” But the mouth of the upright will deliver them. 7 The wicked are overthrown and are no more, But the house of the righteous will stand."));
        Proverbs12_5_7.SetReference("Proverbs", "12", "5-7");
        Console.WriteLine(Proverbs12_5_7.GetScripture());

        Console.Write("Hello welcome to the scripture memorizer, would you like to memorize the scripture?\ny/n>");
        Answer = Console.ReadLine();
        if(Answer == "y")
        {
            Console.Clear();
            Console.WriteLine(Proverbs12_5_7.GetScriptureReference());
            Console.WriteLine(Proverbs12_5_7.GetScripture());
            while(Proverbs12_5_7.IsAllBlank() == false)
            {
                string GoAhead = Console.ReadLine();
                Console.Clear();
                Proverbs12_5_7.BlurOut();
                Console.WriteLine(Proverbs12_5_7.GetScriptureReference());
                Console.WriteLine(Proverbs12_5_7.GetScripture());
            }
        Console.Clear();
        }
    }
}
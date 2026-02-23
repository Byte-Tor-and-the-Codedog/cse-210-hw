using System;

class Entry

{
    public string _date;
    public string _prompt;
    public string _text;

    public string GetJournalEntry()
    {
        return $"Date: {_date}, prompt: {_prompt}\n{_text}";
    }
}


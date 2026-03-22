using System;
using System.Security.Cryptography;
public class Reference

{
    private string _book;
    private string _chapter;
    private string _verse;

    public void SetBook(string book)
    {
        _book = book;
    }
    public void SetChapter(string chapter)
    {
        _chapter = chapter;
    }
    public void SetVerse(string verse)
    {
        _verse = verse;
    }
    public string GetReference()
    {
        return($"{_book} {_chapter}:{_verse}");
    }
    
}
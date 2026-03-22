using System;
using System.Security.Cryptography;
public class Scripture

{
    Random rnd = new Random();
    private Reference _scriptureReference;
    private Word[] _scripture;

    public void SetScripture(Word[] array)
    {
        _scripture = array;
    }

    public Word[] GetWordArray(string scripture)
    {
        string[] words = scripture.Split(" ");
        Word[] scriptureArray = new Word[words.Length];
        int i = 0;
        foreach(string word in words)
        {
            scriptureArray[i] = new Word();
            scriptureArray[i].SetWordText($"{word}");
            scriptureArray[i].SetBlank(false);
            i++;
        }
        return scriptureArray;
    }
    public void BlurOut()
    {
        int blurAmount = rnd.Next(1, 3);
        for(int i = 0; i < blurAmount; i++)
        {
            int choice = rnd.Next(0, _scripture.Length);
            while(_scripture[choice].IsBlank() == true)
            {
                choice = rnd.Next(0, _scripture.Length);
            }
            _scripture[choice].BlurOut();
            _scripture[choice].SetBlank(true);
            
        }
    }
    public void SetReference(string book, string chapter, string verse)
    {
        _scriptureReference = new Reference();
        _scriptureReference.SetBook(book);
        _scriptureReference.SetChapter(chapter);
        _scriptureReference.SetVerse(verse);
    }
    public string GetScriptureReference()
    {
        return _scriptureReference.GetReference();
    }
    public string GetScripture()
    {
        string scriptureText = "";
        foreach(Word word in _scripture)
        {
            scriptureText = scriptureText + word.GetWordText() + " ";
        }
        return scriptureText;
    }
    public bool IsAllBlank()
    {
        foreach(Word word in _scripture)
        {
            if(word.IsBlank() == false)
            {
                return false;
            }
        }
        return true;
    }
}
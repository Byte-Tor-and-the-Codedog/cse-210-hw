using System.Security.Cryptography.X509Certificates;

public class Word
{
    private string _wordText;

    private bool _blanked;

    public void SetBlank(bool x)
    {
        _blanked = x;
    }
    public string GetWordText()
    {
        return _wordText;
    }
    public void SetWordText(string x)
    {
        _wordText = x;
    }
    public void BlurOut()
    {
        char[] chars = _wordText.ToCharArray();
        for(int i = 0; i < chars.Length; i++)
        {
            chars[i] = '_';
        }
        _wordText = new string(chars);
    }
    public bool IsBlank()
    {
        return _blanked;
    }
}
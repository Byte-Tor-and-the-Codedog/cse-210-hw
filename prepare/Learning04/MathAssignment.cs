using System.Runtime.CompilerServices;

public class MathAssignment : Assignment
{
    private string _chapter;
    private string _problems;

    public MathAssignment()
    {
        _studentName = "John Doe";
        _topic = "Introduction to Mathematics";
        _chapter = "1.1";
        _problems = "1-10";
    }
    public string GetHomeWorkList()
    {
        return $"{GetSummary()}\nChapter: {_chapter} Problems: {_problems}";
    }
    public void SetProblems(string problem)
    {
        _problems = problem;
    }
    public void SetChapter(string Chapter)
    {
        _chapter = Chapter;
    }
}
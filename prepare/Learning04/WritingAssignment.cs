public class WritingAssignment : Assignment
{
    public string _title;
    public WritingAssignment()
    {
        _studentName = "Jane Doe";
        _topic = "Remedial English";
        _title = "Learning to Read";
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        return $"{GetSummary()}\nTitle: {_title}";
    }
}
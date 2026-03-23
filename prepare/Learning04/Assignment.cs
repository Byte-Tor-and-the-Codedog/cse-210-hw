using System;
public class Assignment
{
    protected string _studentName;
    protected string _topic;
    public string GetSummary()
    {
        return $"Student: {_studentName} Topic: {_topic}";
    }
    public void SetStudentName(string name)
    {
        _studentName = name;
    }
    public void SetTopic(string topic)
    {
        _topic = topic;
    }
}

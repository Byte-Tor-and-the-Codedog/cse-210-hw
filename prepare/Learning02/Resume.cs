using System;
public class Resume
{
    public string _name;
    public List<Job> _job;
    public Resume()
    {
        _job = new List<Job>();
    }
    public void DisplayResume()
    {
        Console.WriteLine($"{_name}");
        foreach ( Job Job in _job)
        {
            Job.DisplayJobDetails();
        }

    }

}
public class Activity
{
    protected string _opener;
    protected string _description;
    private List<string> _frames;

    public List<string> GetFrames()
    {
        return _frames;
    }

    public void SetFrames()
    {
        _frames.Add("|");
        _frames.Add("/");
        _frames.Add("-");
        _frames.Add("\\");
        _frames.Add("|");
        _frames.Add("/");
        _frames.Add("-");
        _frames.Add("\\");
    }
    //I wrote this animation out of curiosity, it looks sort of evil like the x is phasing in and out of reality. This inspired me to make the activities evil.
    public void Animate(int time)
    {
        DateTime endTime = DateTime.Now.AddSeconds(time);
        while(DateTime.Now < endTime)
        foreach(string frame in _frames)
        {
            Console.Clear();
            Console.Write($"{frame}      {frame}\n"
            + $" {frame}    {frame}\n"
            + $"  {frame}  {frame}  \n"
            + $"   {frame}{frame}   \n"
            + $"  {frame}  {frame}  \n"
            + $" {frame}    {frame}\n"
            + $"{frame}      {frame}\n");
            Thread.Sleep(100);
        }
    }
        

        public Activity()
    {
        _description = "test for animation";
        _opener = " let's see";
        _frames = new List<string>();
        _frames.Add("|");
        _frames.Add("/");
        _frames.Add("-");
        _frames.Add("\\");
        _frames.Add("|");
        _frames.Add("/");
        _frames.Add("-");
        _frames.Add("\\");
    }
    

}
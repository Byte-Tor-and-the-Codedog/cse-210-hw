using System;

class Program
{
        static void Main(string[] args)
    {
        Job Job1 = new Job();
        Job1._jobTitle = "2nd Assistant Space Whale Scrubber";
        Job1._company = "Lockheed Martin";
        Job1._startYear = 2026;
        Job1._endYear = 2036;
        
        Job Job2 = new Job();
        Job2._jobTitle = "Chimp Tickler";
        Job2._company = "Idaho National Labs";
        Job2._startYear = 2036;
        Job2._endYear = 2044;

        Resume me = new Resume();
        me._name = "Terrence";
        me._job.Add(Job1);
        me._job.Add(Job2);
        me.DisplayResume();


}
}
//next: 
//Grok numbers:  Swim average pace = 60s/100 yards for 500 yard swim.  Run for 5000m run = 9.1 min/ mile (5:45 min/km).  cycling 60 miles, amateur = 15mph (24km/h) competetive = 20mph (32km/h).  all values are on the slower end of the scale.

using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activities = new List<Activity>();

        //format = date, length(time ran in minutes), distance (miles)
        Running running = new Running("15 Oct 2025", 25, 3.0);
        _activities.Add(running);
        //format = date, length(time ran in minutes), # of laps (50m each)
        Swimming swimming = new Swimming("12 Oct 2025", 35, 50);
        _activities.Add(swimming);
        //format = date, length(time ran in minutes), cycling speed (mph)
        Cycling cycling = new Cycling("10 Oct 2025", 60, 18);
        _activities.Add(cycling);

        foreach (Activity instance in _activities)
        {
            Console.WriteLine(instance.GetSummary());
        }
    }
}
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create instances of activities
        var activities = new List<BaseActivity>
        {
            new RunningActivity(new DateTime(2022, 11, 3), 30, 3.0),
            new CyclingActivity(new DateTime(2022, 11, 3), 30, 15.0),
            new SwimmingActivity(new DateTime(2022, 11, 3), 30, 20)
        };

        // Display summaries for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

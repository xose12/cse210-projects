using System;

public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CurrentCount { get; set; }

    public ChecklistGoal(string name, int points, int targetCount) : base(name, points)
    {
        TargetCount = targetCount;
        CurrentCount = 0;
    }

    public override void RecordEvent()
    {
        CurrentCount++;
        Console.WriteLine($"Recorded event for {Name}. Earned {Points} points. ({CurrentCount}/{TargetCount})");
        if (CurrentCount >= TargetCount)
        {
            Console.WriteLine($"Completed {Name}! Earned bonus points.");
        }
    }
}


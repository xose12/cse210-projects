using System;

public class RunningActivity : BaseActivity
{
    public double Distance { get; set; }

    public RunningActivity(DateTime date, int duration, double distance) 
        : base(date, duration)
    {
        Distance = distance;
    }

    public override double GetDistance() => Distance;

    public override double GetSpeed() => (Distance / DurationInMinutes) * 60; // Speed in mph

    public override double GetPace() => DurationInMinutes / Distance; // Pace in min per mile
}

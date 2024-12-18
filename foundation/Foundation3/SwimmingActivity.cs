using System;

public class SwimmingActivity : BaseActivity
{
    public int Laps { get; set; }

    public SwimmingActivity(DateTime date, int duration, int laps)
        : base(date, duration)
    {
        Laps = laps;
    }

    public override double GetDistance() => (Laps * 50) / 1000.0; // Distance in kilometers

    public override double GetSpeed() => (GetDistance() / DurationInMinutes) * 60; // Speed in km/h

    public override double GetPace() => DurationInMinutes / GetDistance(); // Pace in min per km
}

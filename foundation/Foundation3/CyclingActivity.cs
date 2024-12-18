using System;

public class CyclingActivity : BaseActivity
{
    public double Speed { get; set; }

    public CyclingActivity(DateTime date, int duration, double speed)
        : base(date, duration)
    {
        Speed = speed;
    }

    public override double GetDistance() => (Speed * DurationInMinutes) / 60; // Distance in miles

    public override double GetSpeed() => Speed; // Speed in mph

    public override double GetPace() => 60 / Speed; // Pace in min per mile
}

using System;

public abstract class BaseActivity
{
    // Shared attributes
    public DateTime Date { get; set; }
    public int DurationInMinutes { get; set; }

    // Constructor
    public BaseActivity(DateTime date, int duration)
    {
        Date = date;
        DurationInMinutes = duration;
    }

    // Abstract methods to be overridden in derived classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // GetSummary method (can be overridden if needed in derived classes)
    public virtual string GetSummary()
    {
        return $"{Date:dd MMM yyyy} {this.GetType().Name} ({DurationInMinutes} min): Distance {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}

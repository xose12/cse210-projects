using System;
using System.Threading;

abstract class Activity
{
    protected int duration;

    public void StartActivity()
    {
        ShowStartingMessage();
        SetDuration();
        PrepareForActivity();
        PerformActivity();
        ShowEndingMessage();
    }

    protected virtual void ShowStartingMessage()
    {
        Console.WriteLine("Starting the activity...");
    }

    protected void SetDuration()
    {
        Console.Write("Enter the duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
    }

    protected virtual void PrepareForActivity()
    {
        Console.WriteLine("Get ready...");
        Thread.Sleep(2000);
    }

    protected abstract void PerformActivity();

    protected void ShowEndingMessage()
    {
        Console.WriteLine($"Great job! You completed {this.GetType().Name} for {duration} seconds.");
        Thread.Sleep(2000);
    }

    protected void ShowCountdown()
    {
        for (int i = 3; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }

    protected void ShowSpinner()
    {
        string[] spinner = { "/", "-", "\\", "|" };
        for (int i = 0; i < 10; i++)
        {
            Console.Write(spinner[i % 4]);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(300);
        }
    }
}

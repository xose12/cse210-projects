using System;
using System.Threading;

class BreathingActivity : Activity
{
    protected override void ShowStartingMessage()
    {
        Console.WriteLine("This activity will help you relax by guiding you through slow, deep breathing.");
        Console.WriteLine("Clear your mind and focus on your breathing.");
    }

    protected override void PerformActivity()
    {
        ShowCountdown();

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner();
            Thread.Sleep(3000);
            Console.WriteLine("Breathe out...");
            ShowSpinner();
            Thread.Sleep(3000);
        }
    }
}

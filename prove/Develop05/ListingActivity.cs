using System;
using System.Collections.Generic;
using System.Threading;

class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    protected override void ShowStartingMessage()
    {
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can.");
    }

    protected override void PerformActivity()
    {
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Count)];
        Console.WriteLine(prompt);

        ShowCountdown();

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        List<string> responses = new List<string>();
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Enter an item (or press Enter to stop):");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                responses.Add(response);
            }
            else
            {
                break;
            }
        }

        Console.WriteLine($"You listed {responses.Count} items.");
        Thread.Sleep(2000);
    }
}

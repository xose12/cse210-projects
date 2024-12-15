using System;
using System.Collections.Generic;

public class GoalManager
{
    public List<Goal> Goals { get; set; }

    public GoalManager()
    {
        Goals = new List<Goal>();
    }

    public void AddGoal(Goal goal)
    {
        Goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        foreach (var goal in Goals)
        {
            if (goal.Name == goalName)
    {
                goal.RecordEvent();
                return;
            }
        }
        Console.WriteLine("Goal not found.");
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Goals:");
        foreach (var goal in Goals)
        {
            Console.WriteLine($"{goal.Name}: {goal.Points} points");
        }
    }

    public void SaveGoals(string filename)
    {
        using (System.IO.StreamWriter writer = new System.IO.StreamWriter(filename))
        {
            foreach (var goal in Goals)
            {
               writer.WriteLine($"{goal.Name},{goal.Points}");
            }
        }
    }

    public void LoadGoals(string filename)
    {
        Goals.Clear();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string name = parts[0];
            int points = int.Parse(parts[1]);
            Goals.Add(new SimpleGoal(name, points));
        }
    }
}


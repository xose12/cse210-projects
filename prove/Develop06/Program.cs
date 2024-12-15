using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        manager.AddGoal(new SimpleGoal("Run a marathon", 1000));
        manager.AddGoal(new EternalGoal("Read scriptures", 100));
        manager.AddGoal(new ChecklistGoal("Attend temple", 50, 10));

        manager.DisplayGoals();

        manager.RecordEvent("Run a marathon");
        manager.RecordEvent("Read scriptures");
        manager.RecordEvent("Attend temple");
        manager.RecordEvent("Attend temple");
        manager.RecordEvent("Attend temple");

        manager.SaveGoals("goals.txt");

        manager.LoadGoals("goals.txt");

        manager.DisplayGoals();
    }
}

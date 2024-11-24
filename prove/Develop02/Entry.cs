// Entry.cs
public class Entry
{
    public string Date { get; set; }
    public string Scripture { get; set; }
    public string Reflection { get; set; }

    public Entry(string date, string scripture, string reflection)
    {
        Date = date;
        Scripture = scripture;
        Reflection = reflection;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Scripture: {Scripture}");
        Console.WriteLine($"Reflection: {Reflection}");
        Console.WriteLine();
    }
}

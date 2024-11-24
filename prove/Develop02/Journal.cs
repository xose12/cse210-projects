using System;
using System.Collections.Generic;

public class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No journal entries found.");
        }
        else
        {
            foreach (Entry entry in entries)
            {
                Console.WriteLine($"Date: {entry.Date}");
                Console.WriteLine($"Scripture: {entry.Scripture}");
                Console.WriteLine($"Reflection: {entry.Reflection}\n");
            }
        }
    }
}

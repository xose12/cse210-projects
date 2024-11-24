// Journal.cs
using System;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> Entries { get; set; }

    public Journal()
    {
        Entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        Entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in Entries)
        {
            entry.DisplayEntry();
        }
    }
}

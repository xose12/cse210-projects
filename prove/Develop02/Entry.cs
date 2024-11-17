using System;

public class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }

    public Entry(string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
        Date = DateTime.Now;  // Automatically sets the current date and time
    }

    public override string ToString()
    {
        return $"{Date.ToString("yyyy-MM-dd HH:mm:ss")} - {Prompt}\n{Response}";
    }
}

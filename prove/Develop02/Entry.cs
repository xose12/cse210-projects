public class Entry
{
    public string Date { get; private set; }
    public string Scripture { get; private set; }
    public string Reflection { get; private set; }

    public Entry(string date, string scripture, string reflection)
    {
        Date = date;
        Scripture = scripture;
        Reflection = reflection;
    }
}

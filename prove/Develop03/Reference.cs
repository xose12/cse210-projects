public class Reference
{
    public string Book { get; }
    public int StartChapter { get; }
    public int EndChapter { get; }
    public int StartVerse { get; }
    public int EndVerse { get; }

    // Constructor for a single verse
    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        StartChapter = chapter;
        EndChapter = chapter;
        StartVerse = verse;
        EndVerse = verse;
    }

    // Constructor for a range of verses
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        Book = book;
        StartChapter = chapter;
        EndChapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    public override string ToString()
    {
        if (StartVerse == EndVerse)
        {
            return $"{Book} {StartChapter}:{StartVerse}";
        }
        else
        {
            return $"{Book} {StartChapter}:{StartVerse}-{EndVerse}";
        }
    }
}

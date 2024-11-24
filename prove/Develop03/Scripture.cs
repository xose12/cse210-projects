using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public Reference Reference { get; }
    public List<Word> Words { get; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void DisplayScripture()
    {
        Console.WriteLine(Reference);
        Console.WriteLine(string.Join(" ", Words.Select(w => w.GetDisplayText())));
    }

    public void HideRandomWord()
    {
        Random rand = new Random();
        var unhiddenWords = Words.Where(w => !w.IsHidden).ToList();

        if (unhiddenWords.Count > 0)
        {
            int randomIndex = rand.Next(unhiddenWords.Count);
            unhiddenWords[randomIndex].Hide();
        }
    }

    public bool AllWordsHidden()
    {
        return Words.All(w => w.IsHidden);
    }
}

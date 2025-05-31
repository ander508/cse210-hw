using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference _reference; // I used Reference data type here
    private List<Word> _words = new List<Word>();   //  I used Word data type here for the List.

    public Scripture(Reference reference, string text)
    {
        
        _reference = reference;
       foreach (string word in text.Split(" "))
       {
           Word w = new Word(word);
           _words.Add(w);
       }
    }

    public void HideRandomWords(int numberToHide)
   {
    Random random = new Random();
    int hiddenCount = 0;

    // Count how many words are still visible
    int visibleCount = 0;

    foreach (Word word in _words)
    {
        if (!word.IsHidden())
        {
            visibleCount++;
        }
    }

    // Limit the number to hide based on available visible words
    int maxHideable = Math.Min(numberToHide, visibleCount);

    while (hiddenCount < maxHideable)
    {
        Word word = _words[random.Next(_words.Count)];
        if (!word.IsHidden())
        {
            word.Hide();
            hiddenCount++;
        }
    }
}

    public string GetDisplayText()
    {
        string scriptureText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_reference.GetDisplayText()} - {scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
            {
                if (!word.IsHidden())
                {
                    return false;
                }
            }
        return true;
    }
}

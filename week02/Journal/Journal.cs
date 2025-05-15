public class Journal
{
    
    public List<Entry> _entries = new List<Entry>();
    
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    
    
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries in the list");
            return;
        }
        
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                string formated = $"{entry._date}~~|~~{entry._promptText}~~|~~{entry._entryText}";
                outputFile.WriteLine(formated);
            }
        }
        Console.WriteLine("Journal saved successfully.");
    }
    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine($"{file} does not exist.");
            return;
        }
        _entries.Clear(); 

        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split("~~|~~");
                string date = parts[0];
                string prompt = parts[1];
                string entryText = parts[2];

                Entry entry = new Entry(prompt, entryText);
                entry._date = date;
                _entries.Add(entry);
        }

        Console.WriteLine("Journal loaded successfully.");
    }

    
}
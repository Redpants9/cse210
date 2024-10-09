public class Journal
{
    List<Entry> entries = new List<Entry>(); 

    public void addentry(Entry newentry)
    {
        entries.Add(newentry);
    }
    public void displayall()
    {
        foreach (Entry e in entries)
        {
            e.Display();
        }

    }
    public void Save(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry e in entries)
            {
                outputFile.WriteLine($"{e.date},{e.promptText},{e.entryText}");
            }
        }
    }
    public void load(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Entry _entry = new Entry();
            _entry.date = parts[0];
            _entry.promptText = parts[1];
            _entry.entryText = parts[2];
            addentry(_entry);
        }
    }
}

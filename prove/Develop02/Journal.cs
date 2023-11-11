public class Journal
{
    private List<Entry> _entries;
    private const string FileName = "journal.txt"; // Fixed file name

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

     public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry.Prompt}|{entry.Response}|{entry.Date}");
            }
        }

        Console.WriteLine($"Entries saved to {fileName}.");
    }

    public void LoadFromFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            _entries.Clear(); // Clear existing entries

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        string prompt = parts[0];
                        string response = parts[1];
                        DateTime date = DateTime.Parse(parts[2]);
                        Entry entry = new Entry(prompt, response, date);
                        _entries.Add(entry);
                    }
                }
            }

            Console.WriteLine($"Entries loaded from {fileName}.");
        }
        else
        {
            Console.WriteLine($"File {fileName} not found. No entries loaded.");
        }
    }
}
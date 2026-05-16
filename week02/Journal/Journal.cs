class Journal
{
    List<Entry> _entries;


    internal Journal()
    {
        _entries = [];
    }


    internal void AddEntry(Entry entry) => _entries.Add(entry);


    internal void PrintEntries()
    {
        Console.Clear();

        foreach (Entry entry in _entries)
        {
            entry.Print();
        }
        
        Console.Write("(Press enter to continue.) ");
        Console.ReadLine();
    }


    internal void Save(string path)
    {
        List<string> formattedEntries = [];

        foreach (Entry entry in _entries)
        {
            formattedEntries.Add(entry.FormatEntry());
        }
        
        File.WriteAllLines(path, formattedEntries);
    }


    internal void Load(string path)
    {
        string[] fileLines = File.ReadAllLines(path);
        List<Entry> entries = [];

        foreach (string fileLine in fileLines)
        {
            entries.Add(new Entry(fileLine));
        }

        _entries = entries;
    }
}
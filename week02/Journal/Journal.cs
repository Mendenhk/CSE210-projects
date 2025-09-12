public class Journal
{
    //a list of class names
    public List<Entry> _entries = new List<Entry>();


    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry item in _entries)
        {
            item.Display();
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry item in _entries)
            {
                outputFile.WriteLine($"{item._date}, {item._promptText}, {item._entryText}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        Console.WriteLine("");
    }
}
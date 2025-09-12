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
        Console.WriteLine("");
    }
    public void LoadFromFile(string file)
    {
        Console.WriteLine("");
    }
}
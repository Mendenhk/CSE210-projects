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
            _entries.Clear();
        }
    }
   
    public void LoadFromFile(string file)
    {
        //reads all file lines into the string array "lines"
        string[] lines = System.IO.File.ReadAllLines(file);
        //separates each string of lines into a smaller array of strings using the comma as a separator.  So in this case it would be an array of three strings.
        foreach (string line in lines)
        {
            Entry entry = new Entry();
            string[] parts = line.Split(",");
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];
            AddEntry(entry);
        }
    }
}
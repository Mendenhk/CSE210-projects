//This class does the following: 
//-gets the display text of the reference (the reference is the book, chapter, and verse(s))
public class Reference
{
    //attributes
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        Console.WriteLine("blank");
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        Console.WriteLine("blank");
    }

    //methods
    //finished: need to check
    public string GetDisplayText()
    {
        string displayText;
        if (_endVerse == 0)
        {
            displayText = $"{_book} {_chapter}:{_verse} ";
        }
        else
        {
            displayText = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        return displayText;
    }
}
//This class does the following:
//-hide and show a word
//-check if a word is hidden or not
//-get the display text of a word (the display text is the word itself, or underscores if the word is hidden)
public class Word
{
    //attributes
    private string _text;
    //added by me
    private bool _isHidden;

    //constructors
    //my added default constructor:
    // public Word()
    // {
    //     _text = "Trust in the Lord with all thine heart; and lean not uto thine own understanding.  In all thy ways acknowledge him, and he shall direct thy paths.";
    // }

    //I think that each text is a single word.  THis constructor accepts the text of a word and saves it as an attribute.  It also sets the initial visibility of the word (shown or hidden).  The word can be visible by default.  
    public Word(string text)
    {
        Console.WriteLine("blank");
        //one of the classes uses this constructor to initialize _text.
    }

    //methods
    public void Hide()
    {
        Console.WriteLine("blank");
    }

    public void Show()
    {
        Console.WriteLine("blank");
    }

    public bool IsHidden()
    {
        Console.WriteLine("blank");
    }

    public string GetDisplayText()
    {
        Console.WriteLine("blank");
    }
}
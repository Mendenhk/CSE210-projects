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

    //CONSTRUCTORS
    //I think that each text is a single word.  THis constructor accepts the text of a word and saves it as an attribute.  It also sets the initial visibility of the word (shown or hidden).  The word can be visible by default.  
    public Word(string text)
    {
        _text = text;
    }

    //METHODS
    public void Hide()
    {
        Console.WriteLine("blank");
    }

    public void Show()
    {
        Console.WriteLine("blank");
    }

    // public bool IsHidden()
    // {
    //     Console.WriteLine("blank");
    // }

    public string GetDisplayText()
    {
        return _text;
    }
}
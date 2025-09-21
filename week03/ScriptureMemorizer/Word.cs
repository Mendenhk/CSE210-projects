//This class does the following:
//-hide and show a word
//-check if a word is hidden or not
//-get the display text of a word (the display text is the word itself, or underscores if the word is hidden)
using System.Diagnostics.CodeAnalysis;

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
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (!_isHidden)
        {
            return _text;
        }
        else
        {
            //returns a string that contains the length number of underscores
            return new string('_', _text.Length);
        }
    }
}
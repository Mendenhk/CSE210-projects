using System.Diagnostics.CodeAnalysis;

public class Word
{
    //ATTRIBUTES
    private string _text;
    private bool _isHidden;

    //CONSTRUCTORS
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
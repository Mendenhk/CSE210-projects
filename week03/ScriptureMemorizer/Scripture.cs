//this class does the following:
//-hide random words
//-"get the display text as a string" whether those words be shown or hidden.
//-checks to see if all words are hidden to determine if the program should end.
public class Scripture
{
    //attributes
    private Reference _reference;

    //list of word objects
    private List<Word> _words = new List<Word>();

    //constructors

    //text is the text of the scripture, so a sting of text (The scripture) is to be passed to this constructor, then the constructor creates a list and splits up the words in the string to create Word objects for each word and put them in the list.
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        //The below should be a method, but no such method was outlined in the assignment.
        string[] textArray = text.Split(" ");
        foreach (string word in textArray)
        {
            Word singleWord = new Word(word);
            _words.Add(singleWord);
        }
    }

    //methods
    // public void HideRandomWords() {
    //     Console.WriteLine("blank");
    // }

    //finished
    public string GetDisplayText()
    {
        string displayText = "";
        string fullText = "";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        fullText = _reference.GetDisplayText() + " " + displayText;
        return fullText;
    }

    // public bool IsCompletelyHidden() {
    //     Console.WriteLine("blank");
    // }
}
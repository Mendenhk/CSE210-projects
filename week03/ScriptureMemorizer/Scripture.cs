//this class does the following:
//-hide random words
//-"get the display text as a string" whether those words be shown or hidden.
//-checks to see if all words are hidden to determine if the program should end.
public class Scripture
{
    //attributes
    private Reference _reference;

    //list of word objects
    private List<Word> _words;

    //constructors

    //text is the text of the scripture, so a sting of text (The scripture) is to be passed to this constructor, then the constructor creates a list and splits up the words in the string to create Word objects for each word and put them in the list.  Where does this constructor get the scripture text?
    public Scripture(Reference reference, string text)
    {
        Console.WriteLine("blank");
    }

    //methods
    public void HideRandomWords() {
        Console.WriteLine("blank");
    }

    //calls the Reference classes GetDisplayText()
    public string GetDisplayText() {
        Console.WriteLine("blank");
    }

    public bool IsCompletelyHidden() {
        Console.WriteLine("blank");
    }
}
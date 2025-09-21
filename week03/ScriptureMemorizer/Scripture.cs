public class Scripture
{
    //ATTRIBUTES
    private Reference _reference;

    //list of word objects
    private List<Word> _words = new List<Word>();

    //CONSTRUCTORS
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        //The below should be a method, but no such method was outlined in the assignment.
        string[] textArray = text.Split(" ");
        foreach (string word in textArray)
        {
            Word singleWord = new Word(word);
            _words.Add(singleWord);
            //initialize boolean to yes so can create list for random
            singleWord.Show();
        }
    }

    //METHODS
    public void HideRandomWords()
    {
        //creates a list of Word instances that are not hidden.  Keeps track of available words to choose from.
        List<Word> availableWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                availableWords.Add(word);
            }
        }

        Random random = new Random();

        //three words hidden because the demo video hid three at a time.
        int wordsToHide = 3; 
        for (int i = 0; i < wordsToHide; i++)
        {
            if (availableWords.Count == 0)
            {
                break; //exits for loop if all words are hidden
            }
            int index = random.Next(0, availableWords.Count);
            //since instances are saved by reference, this should also change the value of the related instance in _words.
            availableWords[index].Hide();
            availableWords.RemoveAt(index);//removes newly hidden word from list of options to hide
        }
    }

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

    public bool IsCompletelyHidden()
    {
        foreach (Word instance in _words)
        {
            if (!instance.IsHidden())
            {
                return false; //returns false if any of the instances/words are not hidden
            }
        }
        return true; //returns true if all of the instances/words are hidden
    }
}
public class MathAssignment : Assignment
{
    //ATTRIBUTES
    private string _textbookSection;
    private string _problems;
    
    //CONSTRUCTORS
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    //METHODS
    public string GetHomeworkList()
    {
        return $"{GetSummary()}\n{_textbookSection} {_problems}";
    }
}

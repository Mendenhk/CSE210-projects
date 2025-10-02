public class WritingAssignment : Assignment
{
    //ATTRIBUTES
    private string _title;
    //CONSTRUCTORS
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    //METHODS
    public string GetWritingInformation()
    {
        return $"{GetSummary()}\n{_title}";
    }
}
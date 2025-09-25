//The video class tracks the title, author and length (in seconds) of the video.
//It Also stores a list of comments, with a method that returns the number of comments
public class Video
{
    //ATTRIBUTES
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    //CONSTRUCTORS
    public Video(string title, string author, int length, List<(string Commenter, string CommentText)> comments) //last imports a list of string tuples, and assigns them the "object-like" names of Name and String so dot notation can be used to extract them. 
    {
        _title = title;
        _author = author;
        _length = length;
        // Console.WriteLine($"\nTitle: {_title}\nAuthor: {_author}\nLength: {_length}");
        foreach (var tuple in comments)
        {
            Comment newComment = new Comment(tuple.Commenter, tuple.CommentText);
            _comments.Add(newComment);  //creates a list of Comment instances
        }
        // foreach (Comment instance in _comments)
        // {
        //     Console.WriteLine(instance.GetComments());
        // }
    }

    //METHODS
    public string GetInformation()
    {
        string informationString = $"Title: {_title}\nAuthor: {_author}\nLength: {_length} seconds";
        return informationString;
    }
    public int GetNumberOfComments()
    {
        int commentsNumber = _comments.Count;  //number of instances in _comments list
        return commentsNumber;
    }

    public string GetComments()
    {
        string commentsString = "";
        foreach (Comment instance in _comments)
        {
            string tempString = instance.GetComments();
            commentsString += tempString;
        }
        return commentsString;
    }
}
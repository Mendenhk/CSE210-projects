//The video class tracks the title, author and length (in seconds) of the video.
//It Also stores a list of comments, with a method that returns the number of comments
public class Video
{
    //ATTRIBUTES
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    //CONSTRUCTORS
    public Video(/*string title, string author, int length, */List<(string Commenter, string CommentText)> comments) { //last imports a list of string tuples, and assigns them the "object-like" names of Name and String so dot notation can be used to extract them.  
        foreach (var comment in comments)
        {
            Console.WriteLine($"Name: {comment.Commenter}, Comment: {comment.CommentText}");
            Console.WriteLine("");
        }
    }

    //METHODS
    public int NumberOfComments()
    {
        //blank
        return 5; //not the correct return
    }
}
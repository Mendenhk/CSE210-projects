//The Comments class defines comments.  It has responsibility for tracking both the name of the person who made the comment and the text of the comment.
public class Comment
{
    //ATTRIBUTES
    private string _name;
    private string _comment;

    //CONSTRUCTORS
    public Comment(string name, string comment)
    {
        _name = name;
        _comment = comment;
    }

    //METHODS   
    public string GetComments()
    {
        string commentsString;
        commentsString = $"-{_name}\n\"{_comment}\"\n";                                                           return commentsString;            
    }
}

//(not finished) the program then iterates through the list of videos and for each one, display the title, author, length, number of comments (from the method) and then list out all of the comments  for that video. Repeat this display for each video in the list.
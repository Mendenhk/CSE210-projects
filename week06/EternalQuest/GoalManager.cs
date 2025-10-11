public class GoalManager
{
    //ATTRIBUTES
    private List<Goal> _goals;
    private int _score;

    //CONSTRUCTORS
    public GoalManager()
    {
        
    }

    //GETTERS AND SETTERS

    //METHODS
    public void Start()
    {
        _score = 0;
    }

    //Displays the players current score.
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.\n");
    }

    // Lists the names of each of the goals.
    public void ListGoalNames()
    {
        Console.WriteLine("hello");
    }

    //Lists the details of each goal (including the checkbox of whether it is complete).
    public void ListGoalDetails()
    {
        Console.WriteLine("hello");
    }

    //Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
    public void CreateGoal()
    {
        Console.WriteLine("hello");
    }

    //Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
    public void RecordEvent()
    {
        Console.WriteLine("hello");
    }

    //Saves the list of goals to a file.
    public void SaveGoals()
    {
        Console.WriteLine("hello");
    }

    //Loads the list of goals from a file.
    public void LoadGoals()
    {
        Console.WriteLine("hello");
    }
}
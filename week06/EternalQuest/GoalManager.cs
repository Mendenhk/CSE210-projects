//GoalManager() - Initializes an empty list of goals and sets the player's score to be 0.
public class GoalManager
{
    //ATTRIBUTES
    private List<Goal> _goals;
    private int _score;

    //CONSTRUCTORS
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    //GETTERS AND SETTERS

    //METHODS
    public void Start()
    {
        _score = 0;
    }

    //(completed) Displays the players current score.
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.\n");
    }

    // CLASS: Lists the names of each of the goals.
    public void ListGoalNames()
    {
        Console.WriteLine("hello");
    }

    //ME: for displaying goals when choice 2 is chosen. Lists the details of each goal (including the checkbox of whether it is complete).
    public void ListGoalDetails()
    {
        foreach (Goal instance in _goals)
        {
            string checkbox;
            if (instance.IsComplete())
            {
                checkbox = "(X)";
            }
            else
            {
                checkbox = "( )";
            }
            Console.WriteLine($"{checkbox} {instance.GetShortName()} ({instance.GetDescription()})");
        }
    }

    //Asks the user for the information about a new goal. Then, creates the goal and adds it to the list. (I added the function parameter)
    public void CreateGoal()
    {
        string goalChoice = "0";
        Console.WriteLine("\nThe types of Goals are;");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which goal would you like to create? ");
        goalChoice = Console.ReadLine();
        if (goalChoice == "1")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
        }
        if (goalChoice == "2")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
            // Console.WriteLine($"name: {simpleGoal.GetShortName()}\ndescription: {simpleGoal.GetDescription()}\npoints: {simpleGoal.GetPoints()}");
        }
    }

    //ME: records an achieved goal.  CLASS: Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal. 
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
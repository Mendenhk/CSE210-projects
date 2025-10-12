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
        Console.WriteLine("\nThe goals are:");
        foreach (Goal instance in _goals)
        {
            Console.WriteLine($"{instance.GetDetailsString(instance)}");
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
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }
        if (goalChoice == "3")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();
            Console.Write("How many times does this goal need to be accomplished for the bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
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
        string filename = "goals.txt";
        using (StreamWriter streamWriter = new StreamWriter(filename))
        {
            streamWriter.WriteLine($"{_score}");
            foreach(Goal instance in _goals)
            {
                string fileLine = instance.GetStringRepresentation();
                streamWriter.WriteLine(fileLine);
            }
        }
    }

    //Loads the list of goals from a file.
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        //below: skips the first string, the score.
        foreach (string line in lines[1..])
        {
            string[] parts = line.Split(",");
            if (parts[0] == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                string points = parts[3];
                bool isComplete = bool.Parse(parts[4]);
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                if (isComplete)
                {
                    simpleGoal.SetIsCompleteTrue();
                }
                _goals.Add(simpleGoal);
            }
            else if (parts[0] == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                string points = parts[3];
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                string name = parts[1];
                string description = parts[2];
                string points = parts[3];
                int target = int.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);
                int amountCompleted = int.Parse(parts[6]);
                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                checklistGoal.SetAmountCompleted(amountCompleted);
                _goals.Add(checklistGoal);
            }
        }
    }
}
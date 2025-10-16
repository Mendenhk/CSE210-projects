public abstract class Activity
{
    //ATTRIBUTES
    //maybe protected rather than private
    private string _date;
    //length of the activity in minutes
    //maybe protected rather than private
    private float _length;

    //CONSTRUCTORS
    public Activity(string date, float length)
    {
        _date = date;
        _length = length;
    }

    //GETTERS AND SETTERS
    public string GetDate => _date; //shorthand way of writing a getter.
    public float GetLength => _length;

    //METHODS
    //these may need to be defined with abstract rather than virtual, class would have to be changed to abstract. See rubric #4
    public abstract float GetDistance();

    public abstract float GetSpeed();

    public abstract float GetPace();

    //GetSummary method is defined in the base class and calls virtual methods for getting the distance, speed, and pace.
    //points docked for the following: GetSummary method is defined in the base class but it is overridden in each of the derived classes, rather than using a single method in the base class that does not need to be overridden.
    //Me: not virtual because will not be overridden
    public string GetSummary(){
        // return "produces a string with all the summary information. (date, event type, length and/or distance, speed and/or pace, number of laps)";
        //this.GetType()Name returns the Type name of the calling child class
        return $"{_date} {this.GetType().Name} ({_length} min) -" +
        $"Distance {GetDistance():F2} mph, " +
        $"Speed {GetSpeed():F2} mph, " +
        $"Pace {GetPace():F2} min per mile";
    }
}
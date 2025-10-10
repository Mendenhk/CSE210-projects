public class Square : Shape
{
    //ATTRIBUTES
    private double _side;

    //CONSTRUCTORS
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    //METHODS
    public override double GetArea()
    {
        return _side * _side;
    }
}
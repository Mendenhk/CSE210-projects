public class Circle : Shape
{
    //ATTRIBUTES
    private double _radius;

    //CONSTRUCTORS
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    //METHODS
    public override double GetArea()
    {
        return 3.14 * _radius * _radius;
    }
}
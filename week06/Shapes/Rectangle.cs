public class Rectangle : Shape
{
    //ATTRIBUTES
    private double _length;
    private double _width;

    //CONSTRUCTORS
    public Rectangle(string color, double width, double length) : base(color)
    {
        _width = width;
        _length = length;
    }

    //METHODS
    public override double GetArea()
    {
        return _length * _width;
    }
}
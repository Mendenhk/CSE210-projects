using System;

//my setters and initialization are not changing the values of top and bottom
class Program
{
    static void Main(string[] args)
    {
        Fraction newFraction = new Fraction();
        // newFraction.SetTop(1);
        // newFraction.SetBottom(3);
        Console.WriteLine(newFraction.GetFractionString());
        Console.WriteLine(newFraction.GetDecimalValue());

        Fraction newFraction2 = new Fraction(5);
        Console.WriteLine(newFraction2.GetFractionString());
        Console.WriteLine(newFraction2.GetDecimalValue());

        Fraction newFraction3 = new Fraction(3, 4);
        Console.WriteLine(newFraction3.GetFractionString());
        Console.WriteLine(newFraction3.GetDecimalValue());

        Fraction newFraction4 = new Fraction(1, 3);
        Console.WriteLine(newFraction4.GetFractionString());
        Console.WriteLine(newFraction4.GetDecimalValue());

    }
}
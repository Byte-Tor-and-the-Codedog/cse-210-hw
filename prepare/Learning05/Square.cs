using System.Reflection.Metadata.Ecma335;

public class Square : Shape
{
    private double _side;
    public override void SetMeasurements()
    {
        Console.Write("How long is the side?\n>");
        double side = double.Parse(Console.ReadLine());
        _side = side;
    }
    public double GetSide()
    {
        return _side;
    }
    public override double GetArea()
    {
        return (_side * _side);
    }

}
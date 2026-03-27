using System;

public class Circle : Shape

{
    protected double _radius;
    public override void SetMeasurements()
    {
        Console.Write("How long is the radius?\n>");
        double side = double.Parse(Console.ReadLine());
        _radius = side;
    }
    public double GetRadius()
    {
        return _radius;
    }
    public override double GetArea()
    {
        return Math.PI * (_radius * _radius);
    }
}
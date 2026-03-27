public class Rectangle : Shape
{
    public double _length;
    public double _width;
    public override void SetMeasurements()
    {
        Console.Write("What is the length?\n>");
        double length = double.Parse(Console.ReadLine());
        Console.Write("What is the width?\n>");
        double width = double.Parse(Console.ReadLine());
        _width = width;
        _length = length;
    }
    public override double GetArea()
    {
        return (_length * _width);
    }
}
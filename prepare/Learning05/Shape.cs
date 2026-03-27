public class Shape
{
    protected string _color;
    protected double _area;
    public void SetColor(string color)
    {
        _color = color;
    }
    public virtual double GetArea()
    {
        return 0;
    }
    public virtual void SetMeasurements()
    {
        Console.Write("test");
    }
    public string GetColor()
    {
        return _color;
    }

    public void SetArea(double area)
    {
        _area = area;
    }
    public double ReturnArea()
    {
        return _area;
    }

}
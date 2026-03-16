public class Fraction
{
    private int _numerator;
    private int _denominator;
    int GetNumerator()
    {
    return _numerator;
    }
    int GetDenominator()
    {
    return _denominator;
    }

    public Fraction()
    {
        _denominator = 1;
        _numerator = 1;
    }

    public Fraction(int Numerator)
    {
        _numerator = Numerator;
        _denominator = 1;
    }
    public Fraction(int Numerator, int Denominator)
    {
        _numerator = Numerator;
        _denominator = Denominator;
    }

    public string GetFractionString()
    {
        return($"{_numerator}/{_denominator}");
    }
    public double GetDecimalValue()
    {
        return(Convert.ToDouble(_numerator) / Convert.ToDouble(_denominator));
    }
    public void SetDenominator(int Denominator)
    {
        _denominator = Denominator;
    }
    public void SetNumerator(int Numerator)
    {
        _numerator = Numerator;
    }
}
    

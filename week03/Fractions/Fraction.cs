class Fraction
{
    private int _numerator;

    private int _denominator;


    internal Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }


    internal Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }


    internal Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }


    internal int GetNumerator() => _numerator;

    internal void SetNumerator(int numerator) => _numerator = numerator;

    internal int GetDenominator() => _denominator;

    internal void SetDenominator(int denominator) => _denominator = denominator;

    internal string GetFractionString() => $"{_numerator}/{_denominator}";

    internal double GetDecimalValue() => (double)_numerator / _denominator;
}
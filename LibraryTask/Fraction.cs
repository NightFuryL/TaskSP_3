namespace LibraryTask;
public class Fraction
{
    public int Numerator { get; set; }
    public int Denominator { get; set; }

    public Fraction(int n, int d)
    {
        Numerator = n;
        Denominator = d;
    }

    public Fraction Add(Fraction other)
    {
        if(other.Denominator == 0 || Denominator == 0)
            throw new DivideByZeroException("Denominator cannot be zero.");
        int n = Numerator * other.Denominator + other.Numerator * Denominator;
        int d = ((Denominator == other.Denominator) ? Denominator : (Denominator * other.Denominator));
        return new Fraction(n, d);
    }
    public static Fraction ToFraction(string strFraction)
    {
        //{Numerator}/{Denominator}
        int n = int.Parse(strFraction.Split("/")[0]);
        int d = int.Parse(strFraction.Split("/")[1]);
        return new Fraction(n, d);
    }
    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }
}
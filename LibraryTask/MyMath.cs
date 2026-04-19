namespace LibraryTask;

public static class MyMath
{
    public static ulong Factorial(int n)
    {
        if(n == 0) return 1;
        if(n < 0) throw new ArgumentException("Negative numbers are not allowed.");
        ulong result = 1;
        for (int i = 1; i <= n; i++)
            result *= (ulong)i;
        return result;
    }

    public static bool IsPrime(int n)
    {
        if (n < 2) return false;

        for (int i = 2; i < n; i++)
            if (n % i == 0)
                return false;

        return true;
    }
    public static bool IsEven(int n) => n % 2 == 0;
    public static bool IsOdd(int n) => n % 2 != 0;
}
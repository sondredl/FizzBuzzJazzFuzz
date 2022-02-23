using System;

public class Rules
{
    public static bool DivisibleByThree(int i)
    {
        return i % 3 == 0;
    }

    public static bool DivisibleByFour(int i)
    {
        return i % 4 == 0;
    }

    public static bool DivisibleByFive(int i)
    {
        return i % 5 == 0;
    }

    public static bool DivisibleByNine(int i)
    {
        return i % 9 == 0;
    }
}

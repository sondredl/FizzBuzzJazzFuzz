using System;

public class Rules
{
    static public bool divisibleByThree(int i)
    {
        return i % 3 == 0;
    }

    static public bool divisibleByFour(int i)
    {
        return i % 4 == 0;
    }

    static public bool divisibleByFive(int i)
    {
        return i % 5 == 0;
    }

    static public bool divisibleByNine(int i)
    {
        return i % 9 == 0;
    }
}

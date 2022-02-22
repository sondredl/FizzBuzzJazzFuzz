using System;

namespace Rules
{
    public class Rules
    {
        static public bool divisibleByThree(int i)
        {
            return i % 3 == 0;
        }

        static public bool divisibleByFive(int i)
        {
            return i % 5 == 0;
        }

        static public bool divisibleByFifteen(int i)
        {
            return i % 15 == 0;
        }

        public static string FizzBuzz()
        {
            return "fizz buzz";
        }

        public static string Fizz()
        {
            return "fizz";
        }

        public static string Buzz()
        {
            return "buzz";
        }

    }
}


namespace FizzBuzz
{

    public class GameCase
    {
        public static void Case(List<KeyValuePair<string, int>> WordSet)
        {
        }

        public static class WordSets
        {
            public static List<KeyValuePair<string, int>> FizzBuzz = new List<KeyValuePair<string, int>>
            {
            new("Fizz", 3),
            new("Buzz", 5)
        };

        }
    }

    public static class Rules
    {
        public static bool LoopRules(int i)
        {
            if (i % 3 == 0)
                return true;
            if (i % 5 == 0)
                return true;
            else
                return false;
        }
        //public static bool Rule(int i)
        //{
        //    static bool DivisibleByThree(int i)
        //{
        //    return i % 3 == 0;
        //}

        //static bool DivisibleByFive(int i)
        //{
        //    return i % 5 == 0;
        //}
        //    return true;
        //}
    }
}

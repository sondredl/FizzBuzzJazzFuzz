using Rule = FizzBuzz.Rules;
using Word = FizzBuzz.KeyValue;

namespace FizzBuzz
{
    internal static class Program
    {
        private static void Main()
        {
            int iteratorSize = 100;

            Game game_1 = new();
            game_1.Del_1(iteratorSize);

            Game game_2 = new();
            game_2.Del_2(iteratorSize);
        }
    }


    public class Game
    {
        public static void Del_1(int iteratorSize)
        {
            Iterator(iteratorSize);
        }

        public static void Del_2(int iteratorSize)
        {
            Iterator(iteratorSize);
            ReverseIterator(iteratorSize);
        }
        public static void Iterator(List<KeyValuePair<string, int>> Fizz, int limit)
        {
            Iterator(iteratorSize);
            ReverseIterator(iteratorSize);
        }

        static void Iterator(KeyValuePair<string, int> Fizz, int iteratorSize)
            for (int i = 1; i<iteratorSize; i++)
            {
                string s = "";
                foreach (KeyValuePair<string, int> kvp in Fizz)
                {
                    int k = kvp.Value;
                    if (Rule.DivisibleByThree(i) && Rule.DivisibleByThree(k)) s += kvp.Key;
                    if (Rule.DivisibleByFive(i) && Rule.DivisibleByFive(k)) s += kvp.Key;
                }
                if (s.Length == 0) Console.WriteLine(i);
                else Console.WriteLine(s);
                s = "";
            }
        }
        static void ReverseIterator(int limit)
            for (int i = 1; i > limit; i++)
{
    string s = "";
    foreach (KeyValuePair<string, int> kvp in Fizz)
    {
        int k = kvp.Value;
        if (Rule.DivisibleByThree(i) && Rule.DivisibleByThree(k)) s += kvp.Key;
        if (Rule.DivisibleByFive(i) && Rule.DivisibleByFive(k)) s += kvp.Key;
    }
    if (s.Length == 0) Console.WriteLine(i);
    else Console.WriteLine(s);
    s = "";
}
        }
    }
}





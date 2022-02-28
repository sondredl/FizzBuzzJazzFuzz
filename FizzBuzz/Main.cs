using Rule = FizzBuzz.Rules;
using Word = FizzBuzz.KeyValue;

namespace FizzBuzz
{
    public static class Program
    {
        static void Main()
        {
            int iterSize = 100;
            List<KeyValuePair<string, int>> Fizz = KeyValue.FizzWords;
            List<KeyValuePair<string, int>> Jazz = KeyValue.JazzWords;
            Game.Iterator(Fizz, iterSize);
            Game game_1 = new();
            //game_1.Del_1(Fizz, iterSize);
            Game.Del_1(Fizz, iterSize);
            Game.Del_2(Fizz, Jazz, iterSize);
        }
    }

    public class Game
    {

        public static void Del_1(List<KeyValuePair<string, int>> Fizz, int iteratorSize)
        {
            Iterator(Fizz, iteratorSize);
        }
        public static void Del_2(List<KeyValuePair<string, int>> Fizz, List<KeyValuePair<string, int>> Jazz, int iteratorSize)
        {
            Iterator(Fizz, iteratorSize);
            ReverseIterator(Jazz, iteratorSize);
        }

        public static void Iterator(List<KeyValuePair<string, int>> Fizz, int limit)
        {
            for (int i = 1; i < limit; i++)
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
        public static void ReverseIterator(List<KeyValuePair<string, int>> Jazz, int limit)
        {
            for (int i = limit; 0 < i; i--)
            {
                string s = "";
                foreach (KeyValuePair<string, int> kvp in Jazz)
                {
                    int k = kvp.Value;
                    if (Rule.DivisibleByNine(i) && Rule.DivisibleByNine(k)) s += kvp.Key;
                    if (Rule.DivisibleByFour(i) && Rule.DivisibleByFour(k)) s += kvp.Key;
                }
                if (s.Length == 0) Console.WriteLine(i);
                else Console.WriteLine(s);
                s = "";
            }
        }
    }
}

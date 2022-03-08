using Xunit;

namespace FizzBuzzJazzFuzz
{
    public static class Program
    {
        static void Main()
        {
            List<KeyValuePair<string, int>> Fizz = KeyValue.FizzWords;
            List<KeyValuePair<string, int>> Jazz = KeyValue.JazzWords;
            List<KeyValuePair<string, int>> Test = KeyValue.TestWords;

            int iterSize = 40;

            Game.FizzBuzz(Fizz, iterSize);
            Game.JazzFuzz(Jazz, iterSize);
        }
    }

    public class Game
    {

        public static void FizzBuzz(List<KeyValuePair<string, int>> Fizz, int iteratorSize)
        {
            string[] printWords = new string[iteratorSize];
            printWords = Iterator(Fizz, iteratorSize;
            Printer(printWords);
        }

        public static void JazzFuzz(List<KeyValuePair<string, int>> Jazz, int iteratorSize)
        {
            Array printwords = Iterator(Jazz, iteratorSize);
            ReversePrinter(printwords);
        }

        public static string[] Iterator(List<KeyValuePair<string, int>> Fizz, int limit)
        {
            // string[] printWords = new string[limit];

            for (int i = 1; i < limit; i++)
            {
                string s = "";
                foreach (KeyValuePair<string, int> kvp in Fizz)
                {
                    int k = kvp.Value;
                    if (Divisible(i, k)) s += kvp.Key;
                }
                if (s.Length == 0)
                {
                    string s2 = i.ToString();
                    printWords[i] = s2;
                }
                else printWords[i] = s;
            }
            return printWords;
        }

        public static void Printer(Array arr)
        {
            foreach (string str in arr)
                Console.WriteLine(str);
        }

        public static void ReversePrinter(Array arr)
        {
            for (int i = arr.Length - 1; i > 0; i--)
            {
                Console.WriteLine(arr.GetValue(i));
            }
        }

        public static bool Divisible(int i, int k)
        {
            return i % k == 0;
        }
    }

    public static class KeyValue
    {
        public static List<KeyValuePair<string, int>> FizzWords = new()
        {
            new("Fizz", 3),
            new("Buzz", 5)
        };

        public static List<KeyValuePair<string, int>> JazzWords = new()
        {
            new("Jazz", 9),
            new("Fuzz", 4)
        };

        public static List<KeyValuePair<string, int>> TestWords = new()
        {
            new("Kizz", 2),
            new("Bozz", 6),
            new("Lezz", 7)
        };
    }

}

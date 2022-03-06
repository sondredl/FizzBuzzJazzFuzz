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

            int iteratorSize = 40;

            string[] printWords = new string[iteratorSize];//  = Iterator(Fizz, iteratorSize);

            Game.FizzBuzz(Fizz, printWords, iteratorSize);
            // Game.JazzFuzz(Jazz, iterSize);

        }
    }

    public class Game
    {

        public static void FizzBuzz(List<KeyValuePair<string, int>> Fizz, string[] printWords, int iteratorSize)
        {
            printWords = Iterator(Fizz, printWords, iteratorSize);
            Printer(printWords);
        }

        public static void JazzFuzz(List<KeyValuePair<string, int>> Jazz, int iteratorSize)
        {
            // Array printWords = Iterator(Jazz, iteratorSize);
            // string[] printWords = Iterator(Jazz, iteratorSize);
            // Printer(printWords);

            //Array printWordsReverse = ReverseOrder(printWords, iteratorSize);
            // string[] printWordsReverse = ReverseOrder(printWords, iteratorSize);
            // Printer(printWordsReverse);
        }

        public static string[] Iterator(List<KeyValuePair<string, int>> Fizz, string[] printWords, int limit)
        {

            for (int i = 0; i <= limit; i++)
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

        public static string[] ReverseOrder(string[] arr, int size)
        {
            string[] revArr = new string[size];
            //revArr = arr.Reverse();
            for (int i = size; i > 0; i--)
            {
                //        revArr[i] = arr[size - i];
                Console.WriteLine(revArr[i]);
                Console.WriteLine(arr[i]);
            }
            return revArr;
        }

        public static void Printer(Array arr)
        {
            foreach (string str in arr)
                Console.WriteLine(str);
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

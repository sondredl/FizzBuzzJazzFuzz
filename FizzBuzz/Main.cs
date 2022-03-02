namespace FizzBuzzJazzFuzz
{
    public static class Program
    {
        static void Main()
        {
            int iterSize = 40;

            List<KeyValuePair<string, int>> Fizz = KeyValue.FizzWords;
            List<KeyValuePair<string, int>> Jazz = KeyValue.JazzWords;
            List<KeyValuePair<string, int>> Test = KeyValue.TestWords;

            Game.FizzBuzz(Fizz, iterSize);

            // Game.JazzFuzz(Fizz, iterSize);
        }
    }

    public class Game
    {

        public static void FizzBuzz(List<KeyValuePair<string, int>> Fizz, int iteratorSize)
        {
            Array printwords = Iterator(Fizz, iteratorSize);
            Printer(printwords);
        }

        public void JazzFuzz(List<KeyValuePair<string, int>> Fizz, List<KeyValuePair<string, int>> Jazz, int iteratorSize)
        {
            Array printwords = Iterator(Jazz, iteratorSize);
            Printer(printwords);
        }

        public static Array Iterator(List<KeyValuePair<string, int>> Fizz, int limit)
        {
            string[] printWords = new string[limit];

            for (int i = 0; i < limit; i++)
            {
                string s = "";
                foreach (KeyValuePair<string, int> kvp in Fizz)
                {
                    int k = kvp.Value;
                    // insert error handlig here
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

        public static void ReverseIterator(List<KeyValuePair<string, int>> Jazz, int limit)
        {
            for (int i = limit; 0 < i; i--)
            {
                string s = "";
                foreach (KeyValuePair<string, int> kvp in Jazz)
                {
                    int k = kvp.Value;
                    if (Divisible(i, k)) s += kvp.Key;
                }
                if (s.Length == 0) Console.WriteLine(i);
                else Console.WriteLine(s);
                s = "";
            }
        }

        public static bool Divisible(int i, int k)
        {
            return i % k == 0;
        }

        public static void Printer(Array arr)
        {
            foreach (string str in arr)
                Console.WriteLine(str);
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
/*
    char[] apple = { 'a', 'p', 'p', 'l', 'e' };
    char[] reversed = apple.Reverse().ToArray();
foreach (char chr in reversed)
    Console.Write(chr + " ");
}
Console.WriteLine();

 This code produces the following output:

 e l p p a
*/

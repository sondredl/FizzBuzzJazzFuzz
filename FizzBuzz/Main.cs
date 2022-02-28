using Rule = FizzBuzz.Rules;
using Word = FizzBuzz.KeyValue;

namespace FizzBuzz
{
    internal static class Program
    {
        private static void Main()
        {
            int iteratorSize = 100;

            List<KeyValuePair<string, int>> Fizz = KeyValue.FizzWords;
            Game game_1 = new();
            game_1.Del_1(Fizz, iteratorSize);

            Game game_2 = new();
            game_2.Del_2(Fizz, iteratorSize);
        }
    }


    public class Game
    {
        public static void Del_1(List<KeyValuePair<string, int>> Fizz, int iteratorSize)
        {
            Iterator(Fizz, iteratorSize);
        }

        //public static void Del_2(List<KeyValuePair<string, int>> Fizz, int iteratorSize)
        //{
        //    Iterator(Fizz, iteratorSize);
        //    //ReverseIterator(Fizz, iteratorSize);
        //}

        //public static void Iterator(List<KeyValuePair<string, int>> Fizz, int limit)
        //{
        //    Iterator(iteratorSize);
        //    ReverseIterator(iteratorSize);
        //}

        public static void Iterator(List<KeyValuePair<string, int>> Fizz, int iteratorSize)
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
//        static void ReverseIterator(List<KeyValuePair<string, int>> Fizz, int iteratorSize)
//            for (int i = 1; i > limit; i++)
//{
//    string s = "";
//    foreach (KeyValuePair<string, int> kvp in Fizz)
//    {
//        int k = kvp.Value;
//        if (Rule.DivisibleByThree(i) && Rule.DivisibleByThree(k)) s += kvp.Key;
//        if (Rule.DivisibleByFive(i) && Rule.DivisibleByFive(k)) s += kvp.Key;
//    }
//    if (s.Length == 0) Console.WriteLine(i);
//    else Console.WriteLine(s);
//    s = "";
//}
    }
}





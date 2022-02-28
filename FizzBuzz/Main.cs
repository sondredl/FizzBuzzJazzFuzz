using System.Collections.Generic;
using Rule = FizzBuzz.Rules;
namespace FizzBuzz
{
    public static class Program
    {
        static void Main()
        {
            int iterSize = 100;
            List<KeyValuePair<string, int>> Fizz = KeyValue.FizzWords;
            Game.Iterator(Fizz, iterSize);
        }
    }


    public class Game
    {

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
    }
}





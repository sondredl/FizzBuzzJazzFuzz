using System.Collections.Generic;
using Rule = FizzBuzz.Rules;
using Word = BuzzWords;

namespace FizzBuzz
{
    public static class Program
    {
        static void Main()
        {
            int iterSize = 100;
            KeyValuePair KV = KeyValue.Fizz;
            Game del_1 = new Game();
            Game.Iterator(iterSize);
        }
    }


    public static class Game
    {
        //public static object KeyValue { get; private set; }

        public static void Run() { }
        public static void Iterator(int limit, List Fizz)
        {
            for (int i = 1; i < limit; i++)
            {
                //if (FizzBuzz[i].ContainsKey(i))
                if (KeyValue.value() == i)
                {
                    Console.WriteLine(KeyValue[0]);
                }
                //var i = Rule.LoopRules(limit);
                //Rules(i);
            }
        }
    }
    public static class KeyValue
    {
        public static List<KeyValuePair<string, int>> Fizz = new()
        {
            new("Fizz", 3),
            new("Buzz", 5)
        };
        //foreach (var val in Fizz)
        //{
        //    Console.WriteLine(val);
        //}
        //public static List<Dictionary<string>> Buzz = new()



        public static Dictionary<string, int> Buzz = new Dictionary<string, int>()
        {
            new KeyValuePair<string, int>()
            {
                "fizz",
            }
            //new("Fizz", 3),
            //new("Buzz", 5)
        };
    }
}





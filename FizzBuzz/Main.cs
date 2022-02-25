using System.Collections.Generic;
using Rule = FizzBuzz.Rules;
using Word = BuzzWords;

namespace FizzBuzz
{
    public static class Program
    {
        static void Main()
        {
            Game del_1 = new Game();
            Game.FizzBuzz();
        }
    }


    public class Game
    {
        public static void FizzBuzz()
        {
            var fizzBuzz = new List<KeyValuePair<string, int>>
            {
                new ("Fizz", 3),
                new ("Buzz", 5)
            };
            foreach (var val in fizzBuzz)
            {
                Console.WriteLine(val);
            }
        }
        public static void Iterator(int limit)
        {
            for (int i = 1; i < limit; i++)
            {
                var i = Rule.LoopRules(limit);
                //Rules(i);
            }
        }
    }
}





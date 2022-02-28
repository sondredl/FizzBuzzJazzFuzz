using System.Collections.Generic;
using Rule = FizzBuzz.Rules;
using Word = FizzBuzz.KeyValue;
//using Word = FizzBuzz.KeyValue;

namespace FizzBuzz
{
    public static class Program
    {
        static void Main()
        {
            int iterSize = 100;
            //KeyValue KV = KeyValue.Fizz;
            Game del_1 = new Game();
            //List Fizz = new List();
            Game.Iterator(iterSize, FizzBuzz.KeyValue Fizz);
        }
    }


    public class Game
    {
        //public static object KeyValue { get; private set; }

        public static void Run() { }
        public static void Iterator(int limit, KeyValuePair Fizz)
        {
            for (int i = 1; i < limit; i++)
            {
                string Word = Fizz[0];
                int WordValue = Fizz[1];
                string PrintString = "";

                if (WordValue == i)
                {
                    PrintString += Word;
                    Console.WriteLine(PrintString);
                }
                //var i = Rule.LoopRules(limit);
                //Rules(i);
            }
        }
    }
}





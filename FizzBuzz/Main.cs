using System.Collections.Generic;
using Rule = FizzBuzz.Rules;
using Word = FizzBuzz.KeyValue;
using Dict = FizzBuzz.KeyValue;
namespace FizzBuzz
{
    public static class Program
    {
        static void Main()
        {
            int iterSize = 20;
            Game del_1 = new Game();
            List<KeyValuePair<string, int>> Fizz = KeyValue.Fizz;
            Game.Iterator(Fizz, iterSize);
        }
    }


    public class Game
    {

        public static void Run() { }
        public static void Iterator(List<KeyValuePair<string, int>> Fizz, int limit)
        {
            for (int i = 1; i < limit; i++)
            {
                string s = "";
                string Word = Fizz[0].Key;
                foreach (KeyValuePair<string, int> kvp in Fizz)
                {
                    if (kvp.Value == i)
                        s += kvp.Key;


                }

                if (s.Length == 0) Console.WriteLine(i);
                else Console.WriteLine(s);
                s = "";
            }
        }
    }
}





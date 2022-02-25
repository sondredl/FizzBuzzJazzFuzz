using Rule = FizzBuzz.Rules;
using Word = BuzzWords;

namespace FizzBuzz
{
    public static class Program
    {
        private static void Main()
        {
            Game game = new Game();
            Game.Iterator();
        }

    }
    public class Game
    {
        public static void Iterator()
        {
            for (int i = 1; i < 20; i++)
            {
                if (Rule.DivisibleByThree(i))
                {
                    Console.WriteLine(Word.Fizz());
                }
                if (Rule.DivisibleByFive(i))
                {
                    Console.WriteLine(Word.Buzz());
                }
                else
                    Console.WriteLine(i);
            }
        }
    }
}





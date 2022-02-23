using Rule = Rules;
using Word = BuzzWords;

namespace FizzBuzz
{
    public class Game
    {
        private static readonly int iteratorSize = 100;
        public static void Iterator()
        {
            for (int i = 1; i < iteratorSize; i++)
            {
                if (Rule.divisibleByThree(i) && Rule.divisibleByFive(i))
                {
                    Console.WriteLine(Word.FizzBuzz());
                }
                else if (Rule.divisibleByThree(i))
                {
                    Console.WriteLine(Word.Fizz());
                }
                else if (Rule.divisibleByFive(i))
                {
                    Console.WriteLine(Word.Buzz());
                }
                else
                    Console.WriteLine(i);
            }
        }

        public static void ReverseIterator()
        {
            for (int i = iteratorSize; i > 1; i--)
            {
                if (Rule.divisibleByNine(i))
                {
                    Console.WriteLine(Word.Jazz());
                }
                else if (Rule.divisibleByFour(i))
                {
                    Console.WriteLine(Word.Fuzz());
                }
                else
                    Console.WriteLine(i);
            }
        }
    }
}

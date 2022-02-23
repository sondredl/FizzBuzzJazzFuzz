using Rule = Rules;
using Word = FizzBuzz.BuzzWords;

namespace FizzBuzz
{
    public class Game
    {
        private static readonly int iteratorSize = 100;
        public static void Iterator()
        {
            for (int i = 1; i < iteratorSize; i++)
            {
                if (Rule.DivisibleByThree(i) && Rule.DivisibleByFive(i))
                {
                    Console.WriteLine(Word.FizzBuzz());
                }
                else if (Rule.DivisibleByThree(i) & !Rule.DivisibleByFive(i))
                {
                    Console.WriteLine(Word.Fizz());
                }
                else if (Rule.DivisibleByFive(i) & !Rule.DivisibleByThree(i))
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
                if (Rule.DivisibleByNine(i))
                {
                    Console.WriteLine(Word.Jazz());
                }
                else if (Rule.DivisibleByFour(i))
                {
                    Console.WriteLine(Word.Fuzz());
                }
                else
                    Console.WriteLine(i);
            }
        }
    }
}

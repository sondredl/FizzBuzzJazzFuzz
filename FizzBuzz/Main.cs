
namespace FizzBuzz
{
    internal static class Program
    {
        private static void Main()
        {
            int iteratorSize = 100;

            Game game_1 = new();
            game_1.Del_1(iteratorSize);

            Game game_2 = new();
            game_2.Del_2(iteratorSize);
        }
    }


    public class Game
    {
        public void Del_1(int iteratorSize)
        {
            Iterator(iteratorSize);
        }

        public void Del_2(int iteratorSize)
        {
            Iterator(iteratorSize);
            ReverseIterator(iteratorSize);
        }

        static void Iterator(int iteratorSize)
        {
            for (int i = 1; i <= iteratorSize; i++)
            {
                if (Rules.DivisibleByThree(i) && Rules.DivisibleByFive(i))
                {
                    Console.WriteLine($"{BuzzWords.fizz}{BuzzWords.buzz}");
                }
                else if (Rules.DivisibleByThree(i) & !Rules.DivisibleByFive(i))
                {
                    Console.WriteLine(BuzzWords.fizz);
                }
                else if (Rules.DivisibleByFive(i) & !Rules.DivisibleByThree(i))
                {
                    Console.WriteLine(BuzzWords.buzz);
                }
                else
                    Console.WriteLine(i);
            }
        }

    static void ReverseIterator(int iteratorSize)
    {
        for (int i = iteratorSize; i > 1; i--)
        {
            if (Rule.DivisibleByNine(i) && Rule.DivisibleByFour(i)
            {
                Console.WriteLine(Word.JazzFuzz());
            }
            else if (Rule.DivisibleByNine(i))
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


namespace FizzBuzz
{
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
            for (int i = 1; i < iteratorSize; i++)
            {
                if (Rules.DivisibleByThree(i) && Rules.DivisibleByFive(i))
                {
                    Console.WriteLine($"{BuzzWords.fizz}{BuzzWords.buzz}");
                }
                else if (Rules.DivisibleByThree(i))
                {
                    Console.WriteLine(BuzzWords.fizz);
                }
                else if (Rules.DivisibleByFive(i))
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
                if (Rules.DivisibleByNine(i))
                {
                    Console.WriteLine(BuzzWords.jazz);
                }
                else if (Rules.DivisibleByFour(i))
                {
                    Console.WriteLine(BuzzWords.fuzz);
                }
                else
                    Console.WriteLine(i);
            }
        }


    }
    public class Rules
    {
        static public bool DivisibleByThree(int i)
        {
            return i % 3 == 0;
        }

        static public bool DivisibleByFour(int i)
        {
            return i % 4 == 0;
        }

        static public bool DivisibleByFive(int i)
        {
            return i % 5 == 0;
        }

        static public bool DivisibleByNine(int i)
        {
            return i % 9 == 0;
        }
    }
    public enum BuzzWords
    {
        fizz,
        buzz,
        jazz,
        fuzz
    }
}

using Rule = FizzBuzz.Rules;
using Word = FizzBuzz.BuzzWords;

Main();

static void Main()
{
    int iteratorSize = 100;

    Game game_1 = new Game();
    Game.Del_1(game_1, iteratorSize);

    Game game_2 = new Game();
    Game.Del_2(game_2, iteratorSize);
}
public class Game
{
    public static void Del_1(Game game, int iteratorSize)
    {

        Game.Iterator(iteratorSize);
    }

    public static void Del_2(Game game, int iteratorSize)
    {
        Game.Iterator(iteratorSize);
        ReverseIterator(iteratorSize);
    }


    static void Iterator(int iteratorSize)
    {
        for (int i = 1; i < iteratorSize; i++)
        {
            if (Rule.DivisibleByThree(i) && Rule.DivisibleByFive(i))
            {
                Console.WriteLine($"{Word.fizz}{Word.buzz}");
            }
            else if (Rule.DivisibleByThree(i))
            {
                Console.WriteLine(Word.fizz);
            }
            else if (Rule.DivisibleByFive(i))
            {
                Console.WriteLine(Word.buzz);
            }
            else
                Console.WriteLine(i);
        }
    }

    static void ReverseIterator(int iteratorSize)
    {
        for (int i = iteratorSize; i > 1; i--)
        {
            if (Rule.DivisibleByNine(i))
            {
                Console.WriteLine(Word.jazz);
            }
            else if (Rule.DivisibleByFour(i))
            {
                Console.WriteLine(Word.fuzz);
            }
            else
                Console.WriteLine(i);
        }
    }


}



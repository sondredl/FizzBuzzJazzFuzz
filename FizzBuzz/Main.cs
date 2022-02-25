using Rule = Rules;
using Word = BuzzWords;

Main();

static void Main()
{
    Game game = new Game();
    Game.Iterator();
}

public class Game
{
    public static void Iterator()
    {
        for (int i = 1; i < 20; i++)
        {
            if (Rule.divisibleByFifteen(i))
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
}


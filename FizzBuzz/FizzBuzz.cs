// See https://aka.ms/new-console-template for more information
using System;
using Rule = Rules;
using Word = BuzzWords;

Main();

static void Main()
{
    Game game = new Game();
    game.iterator();
    game.reverseIterator();
}

public class Game
{
    private int iteratorSize = 100;
    public void iterator()
    {
        for (int i = 1; i < iteratorSize; i++)
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

        Console.WriteLine("Iteration limit reached");
        //reverseIterator();
    }
    public void reverseIterator()
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


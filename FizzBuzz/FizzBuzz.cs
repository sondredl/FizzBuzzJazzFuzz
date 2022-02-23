﻿// See https://aka.ms/new-console-template for more information
using System;
using Rule = Rules;
using Word = BuzzWords;

Main();

static void Main()
{
    Game game = new Game();
    game.Iterator();
    game.ReverseIterator();
}

public class Game
{
    private int iteratorSize = 100;
    public void Iterator()
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

    public void ReverseIterator()
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


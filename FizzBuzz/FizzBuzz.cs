﻿// See https://aka.ms/new-console-template for more information
using System;
using Rule = Rules;
using Word = BuzzWords;

Main();

static void Main()
{
    Game game = new Game();
    game.iterator();
}

public class Game
{
    public void iterator()
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


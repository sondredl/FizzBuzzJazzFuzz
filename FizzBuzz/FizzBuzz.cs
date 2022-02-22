// See https://aka.ms/new-console-template for more information
using System;
using Rule = Rules.Rules;

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
                Console.WriteLine(Rule.FizzBuzz());
            }
            else if (Rule.divisibleByThree(i))
            {
                Console.WriteLine(Rule.Fizz());
            }
            else if (Rule.divisibleByFive(i))
            {
                Console.WriteLine(Rule.Buzz());
            }
            else
                Console.WriteLine(i);
        }
    }
}


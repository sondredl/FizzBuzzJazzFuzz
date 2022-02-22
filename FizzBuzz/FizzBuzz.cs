// See https://aka.ms/new-console-template for more information
using System;
using Rules;

Main();

static void Main()
{
    Game game = new Game();
    Game.dummyFunc();
}

public class Game
{
    private static string fizz = "fizz";
    private static string buzz = "buzz";
    private static bool switching = false;

    public void print(string str)
    {
        Console.WriteLine(str);
    }

    public static void dummyFunc()
    {
        for (int i = 0; i < 10; i++)
        {
            if (switching)
            {
                Console.WriteLine("fizz");
                switching = !switching;
                Rules.Rules.Fizz();
            }
            else
            {
                Console.WriteLine("buzz");
                Rules.Rules.Buzz();
                switching = !switching;
            }
        }
    }
}


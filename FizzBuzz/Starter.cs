using Game = FizzBuzz.Game;

Starter.Main();

public class Starter
{

    public static void Main()
    {
        //del_1();
        del_2();
    }

    static void del_1()
    {
        Game game = new Game();

        Game.Iterator();
    }

    static void del_2()
    {
        Game game = new Game();

        Game.Iterator();
        Game.ReverseIterator();
    }
}



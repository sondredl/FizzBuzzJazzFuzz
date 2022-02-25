using Game = FizzBuzz.Game;
//using Rule = FizzBuzz.Rules;
//using Word = FizzBuzz.BuzzWords;

Main();

static void Main()
{
    int iteratorSize = 100;

    Game game_1 = new Game();
    Game.Del_1(game_1, iteratorSize);

    Game game_2 = new Game();
    Game.Del_2(game_2, iteratorSize);
}



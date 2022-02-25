using Game = FizzBuzz.Game;

Play();

static void Play()
{
    int iteratorSize = 100;

    Game game_1 = new();
    Game.Del_1(game_1, iteratorSize);

    Game game_2 = new();
    Game.Del_2(game_2, iteratorSize);
}



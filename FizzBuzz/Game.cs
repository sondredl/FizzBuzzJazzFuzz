
namespace FizzBuzz
{

    public class GameCase
    {
        public static void Case(List<KeyValuePair<string, int>> wordSet, Order order)
        {
            switch (order)
            {
                case Order.Descending:
                    for (int i = 100; i >= 1; i--)
                    {
                        string output = "";
                        foreach ((string key, int value) in wordSet)
                        {
                            if (i % value == 0)
                            {
                                output += key;
                            }
                        }

                        if (output == "")
                        {
                            output = Convert.ToString(i);
                        }
                        Console.WriteLine(output);
                    };
                    break;
                case Order.Ascending:
                    for (int i = 1; i <= 100; i++)
                    {
                        string output = "";
                        foreach ((string key, int value) in wordSet)
                        {
                            if (i % value == 0)
                            {
                                output += key;
                            }
                        }

                        if (output == "")
                        {
                            output = i.ToString();
                        }
                        Console.WriteLine(output);
                    }
                    break;
                default:
                    break;
            }
        }

        public enum Order
        {
            Descending,
            Ascending
        }

        public static class WordSets
        {
            public static List<KeyValuePair<string, int>> FizzBuzz = new List<KeyValuePair<string, int>>
        {
            new("Fizz", 3),
            new("Buzz", 5)
        };

            public static List<KeyValuePair<string, int>> ExpandBuzz = new List<KeyValuePair<string, int>>
        {
            new("Jazz", 9),
            new("Lezz", 7),
            new("Bozz", 6),
            new("Fuzz", 4),
            new("Kizz", 2)
        };
        }
    }

    public class Rules
    {
        public static bool DivisibleByThree(int i)
        {
            return i % 3 == 0;
        }

        public static bool DivisibleByFive(int i)
        {
            return i % 5 == 0;
        }

        public static bool DivisibleByFifteen(int i)
        {
            return i % 15 == 0;
        }
    }
}

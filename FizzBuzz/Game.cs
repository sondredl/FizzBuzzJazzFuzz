
namespace FizzBuzz
{
    public static class KeyValue
    {
        public static List<KeyValuePair<string, int>> FizzWords = new()
        {
            new("Fizz", 3),
            new("Buzz", 5)
        };

        public static List<KeyValuePair<string, int>> JazzWords = new()
        {
            new("Jazz", 9),
            new("Fuzz", 4)
        };
    }

    public static class Rules
    {
        public static bool DivisibleByThree(int i)
        {
            return i % 3 == 0;
        }
        public static bool DivisibleByFour(int i)
        {
            return i % 4 == 0;
        }
        public static bool DivisibleByFive(int i)
        {
            return i % 5 == 0;
        }
        public static bool DivisibleByNine(int i)
        {
            return i % 9 == 0;
        }


    }
}

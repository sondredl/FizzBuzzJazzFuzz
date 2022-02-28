
namespace FizzBuzz
{
    public static class KeyValue
    {
        public static List<KeyValuePair<string, int>> FizzBuzz = new()
        {
            new("Fizz", 3),
            new("Buzz", 5)
        };
    }

    public static class Rules
    {
        public static bool DivisibleByThree(int i)
        {
            return i % 3 == 0;
        }

        public static bool DivisibleByFive(int i)
        {
            return i % 5 == 0;
        }
    }
}


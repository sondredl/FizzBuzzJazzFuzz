
namespace FizzBuzz
{
    public static class KeyValue
    {
        public static List<KeyValuePair<string, int>> FizzWords = new()
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

        public static string FizzBuzz()
        {
            return "fizz buzz";
    }

        public static string Jazz()
        {
            return "jazz";
}

        public static string Fuzz()
        {
            return "fuzz";
        }
        public static string JazzFuzz()
        {
            return "JazzFuzz";
        }
    }
}

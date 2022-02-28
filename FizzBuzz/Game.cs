
namespace FizzBuzz
{
    public class Rules
    {
        static public bool DivisibleByThree(int i)
        {
            return i % 3 == 0;
        }

        static public bool DivisibleByFour(int i)
        {
            return i % 4 == 0;
        }

        static public bool DivisibleByFive(int i)
        {
            return i % 5 == 0;
        }

        static public bool DivisibleByNine(int i)
        {
            return i % 9 == 0;
        }
    }
    public enum BuzzWords
    {
        public static string Fizz()
        {
            return "fizz";
        }

        public static string Buzz()
        {
            return "buzz";
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

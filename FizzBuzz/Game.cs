
namespace FizzBuzz
{
    public class Rules
    {
        static public bool DivisibleByThree(int i)
        {
            return i % 3 == 0;
        }

        static public bool DivisibleByFive(int i)
        {
            return i % 5 == 0;
        }

        static public bool DivisibleByFifteen(int i)
        {
            return i % 15 == 0;
        }
    }
}

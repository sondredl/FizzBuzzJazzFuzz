using System.Collections.Generic;
using Rule = FizzBuzz.Rules;
using Word = BuzzWords;

namespace FizzBuzz
{
    public static class Program
    {
        static void Main()
        {
            Game fizzBuzz = new Game();
            //fizzBuzz.Iterator();
            //FizzBuzz.GameCase.Case();
            //List<KeyValuePair<string, int>>? myList = List<KeyValuePair<string, int>>;

            var myList = new List<KeyValuePair<string, int>>
            {
                //new KeyValuePair<string, int>("Laptop", 20),
                //new KeyValuePair<string, int>("Desktop", 40),
                //new KeyValuePair<string, int>("Tablet", 60),
                new("Laptop", 20),
                new("Desktop", 40),
                new("Tablet", 60)
            };
            foreach (var val in myList)
            {
                Console.WriteLine(val);
            }
        }

    }


    public class Game
    {
        static class keyValue
        {
            //List<KeyValuePair<string, int>>? myList = List<KeyValuePair<string, int>>
            //{
            //new ("fizz", 3),
            //new ("buzz", 5)
            //}
        }
    }
    //public string myList { get; set; }
}





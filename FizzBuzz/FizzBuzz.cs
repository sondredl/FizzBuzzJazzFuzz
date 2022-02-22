// See https://aka.ms/new-console-template for more information
using System;

public class Game : Rules 
{


static public class Rules(Game game){ 
    public static string fizz;// = "fizz";
    public static string buzz = "buzz";
    public static bool switching = false;
     public static void dummyFunc()
    {

        for (int i = 0; i < 10; i++) {
            if (switching) {
                Console.WriteLine(fizz);
                switching = !switching;
            } else {
                Console.WriteLine(buzz);
                switching = !switching;
            }
        }
    }

    public static void main() { 
        dummyFunc();
    }
}

}

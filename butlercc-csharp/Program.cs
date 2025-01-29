using static System.Console;
class DemoVariables
{
    static void Main()
    {
        int score = 20;
        double bankBalance = 345.67;
        score  = (int)bankBalance + 2; //Was "5" but added a ".2" at the end to see it change from int to double.
        //Did implicit by adding "(int)" and changing swaping identifiers and changing 5.2 to 2.
        Console.WriteLine("score is {0}", score);
        Console.WriteLine("bankBlance is {0}", bankBalance);
    }
}
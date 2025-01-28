using static System.Console;
class DisplaySomeMoney2
{
    static void Main()
    {
        double someMoney = 39.45;
        string mySentence =
            String.Format("The money is ${0} exactly", someMoney);
        WriteLine(mySentence);
    }
}

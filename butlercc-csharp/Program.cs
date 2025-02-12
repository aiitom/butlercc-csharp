// Program compares your name to the name of your boss
using System;
using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        const int HIGH = 10;
        string numberString;
        int number;
        Write("Enter an interger ");
        numberString = ReadLine();
        number = Convert.ToInt32(numberString);
        if (number > HIGH)
            WriteLine("{0} is greater than {1}", number, HIGH);
        else
            WriteLine("{0} is not greater than {1}", number, HIGH);
    }
}
// Program compares your name to the name of your boss
using System;
using static System.Console;
class CompareThreeNumbers
{
    private static void Main(string[] args)
    {
        string numberString;
        int num1, num2, num3;
        Write("Enter an interger ");
        numberString = ReadLine();
        num1 = Convert.ToInt32(numberString);
        Write("Enter an interger ");
        numberString = ReadLine();
        num2 = Convert.ToInt32(numberString);
        Write("Enter an interger ");
        numberString = ReadLine();
        num3 = Convert.ToInt32(numberString);
        if (num1 == num2)
            if (num1 == num3)
                WriteLine("All three numbers are equal");
            else
                WriteLine("First two are equal");
        else
                if (num1 == num3)
            WriteLine("First and last are equal");
        else
                if (num2 == num3)
            WriteLine("Last two are equal");
        else
            WriteLine("No two numbers are equal");

    }
}
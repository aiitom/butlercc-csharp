// Program compares your name to the name of your boss
using System;
using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        string numberString;
        int age;
        Write("Enter an age number ");
        numberString = ReadLine();
        age = Convert.ToInt32(numberString);
        if (age < 0 || age > 120)
            WriteLine("Age is not valid");
        else
        {
            WriteLine("Age is valid");


        }
    }
}
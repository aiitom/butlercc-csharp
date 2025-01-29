using System;
using static System.Console;
class DemoVariables
{
    static void Main()
    {
        string name, firstString, secondString;
        int first, second, sum;
        Write("Enter your name... ");
        name = ReadLine();
        Write("Hello {0}! Enter the first integer... ", name);
        firstString = ReadLine();
        first = Int32.Parse(firstString);
        Write("Enter the second integer... ");
        secondString = ReadLine();
        second = Int32.Parse(secondString);
        sum = first + second;
        WriteLine("{0}, the sum of {1} and {2} is {3}", name, first, second, sum);
    }
}
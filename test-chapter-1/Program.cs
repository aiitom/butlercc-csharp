using System;
using static System.Console;
using System.Globalization;
using System.Reflection.Metadata;
class FourHellos
{
    static void Main()
    {
        // Write your code here
        int number = 1;
        const int LIMIT = 5;
        while (number < LIMIT) {
            WriteLine("Hello");
            number = number + 1;
        }
    }
}
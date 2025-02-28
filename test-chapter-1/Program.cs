using System;
using static System.Console;
using System.Globalization;
using System.Reflection.Metadata;
using static System.Array;
class FindPriceWithForLoop
{
    static void Main()
    {
        string[] names = { "Olive", "Patty", "Richard", "Ned", "Mindy" };
        int x;
        Array.Sort(names);
        for (x = 0; x < names.Length; ++x)
            WriteLine(names[x]);
    }
}
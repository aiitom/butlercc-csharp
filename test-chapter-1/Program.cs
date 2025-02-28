using System;
using static System.Console;
using System.Globalization;
using System.Reflection.Metadata;
using static System.Array;
class ArrayDemo2
{
    static void Main()
    {
        int[] scores = new int[8];
        int x;
        string inputString;
        int count;
        const int DASHES = 50;
        for (x = 0; x < scores.Length; ++x)
        {
            Write("Enter your score on test {0} ", x + 1);
            inputString = ReadLine();
            scores[x] = Convert.ToInt32(inputString);
        }
        for (count = 0; count < DASHES; ++count)
            Write("-");
            WriteLine();
        WriteLine("Scores in original order: ");
        for (x = 0; x < scores.Length; ++x)
            Write("{0, 6}", scores[x]);
            WriteLine();
        for (count = 0; count <= DASHES; ++count)
            Write("-");
        WriteLine();
        Array.Sort(scores);
        WriteLine("Scores in sorted order:");
        for (x = 0; x < scores.Length; ++x)
            Write("{0,6}", scores[x]);
        WriteLine();
        for (count = 0; count < DASHES; ++count)
            Write("-");
        WriteLine();
        Array.Reverse(scores);
        WriteLine("Scores in reverse order:");
        for (x = 0; x < scores.Length; ++x)
            Write("{0,6}", scores[x]);
    }
}
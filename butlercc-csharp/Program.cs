// Program compares your name to the name of your boss
using System;
using static System.Console;
const int HIGH = 10, LOW = 5;
string numberString;
int number;
Write("Enter an interger ");
numberString = ReadLine();
number = Convert.ToInt32(numberString);
if (number < LOW)
    if (number < HIGH)
        WriteLine("{0} is between {1} and {2}", number, LOW, HIGH);

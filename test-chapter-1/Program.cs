using System;
using static System.Console;
using System.Globalization;
using System.Reflection.Metadata;
class ValidID
{
    static void Main()
    {
        // Write your code here
        //Declare loop control variable and limit
        int x;
        const int LIMIT = 10;

        // Using a while loop to display 1 through 10
        x = 1;
        while(x <= LIMIT)
        {
            WriteLine(x);
            ++x;
        }

        // Using a for loop to display 1 though 10
        for(x = 1;  x <= LIMIT; ++x)
            WriteLine(x);
        }
    
        }
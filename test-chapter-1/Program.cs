using System;
using static System.Console;
using System.Globalization;
using System.Reflection.Metadata;
class FourHellos
{
    static void Main()
    {
        // Write your code here
        int number = 1; // starting at 1 then keeps adding +1 til 5 makes 4 hellos, if int number = 0, they would show hello 5 times
        const int LIMIT = 5;
        // Limit sets a max number for 4 since int number equals 1
        //while put the new that will be used from the bottom and the number<limit is bool

        //curly braces surrond the body of the while loop, keep the expected output in that. Make sure to have no ";" in the while() part
        while (number < LIMIT) {
            WriteLine("Hello"); 
            number = number + 1; //Can use number++, ++number or number += 1
        }
    }
}
using System;
using static System.Console;
using System.Globalization;
using System.Reflection.Metadata;
class ValidID
{
    static void Main()
    {
        // Write your code here
        int idNum;
        string input;
        const int LOW = 1000;
        const int HIGH = 9999;
        Write("Enter an ID number: ");
        input = ReadLine();
        idNum = Convert.ToInt32(input);
        while(idNum < LOW || idNum > HIGH)
        {
            Console.WriteLine("{0} is an invalid number", idNum);
            Write("ID numbers must be ");
            WriteLine("between {0} and {1} inclusive", LOW, HIGH);
            Write("Enter an ID number: ");
            input = ReadLine();
            idNum = Convert.ToInt32(input);
            WriteLine("ID number {0} is valid", idNum);
        }
    
        }
    }
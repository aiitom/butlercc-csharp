// Program compares your name to the name of your boss
using System;
using static System.Console;
internal class DemoORAndAnd
{
    private static void Main(string[] args)
    {
        string inputString;
        int year;
        int deliveryZone;;
        WriteLine("Enter year: ");
        inputString = ReadLine();
        year = Convert.ToInt32(inputString);
        switch(year)
        {
            case 1:
                WriteLine("Freshman");
                break;
            case 2:
                WriteLine("Sophomore");
                break;
            case 3:
                WriteLine("Junior");
                break;
            case 4:
                WriteLine("Senior");
                break;
            default:
                WriteLine("Invalid Year");
                break;

        }    


        }
    }
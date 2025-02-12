// Program compares your name to the name of your boss
using System;
using static System.Console;
internal class DemoORAndAnd
{
    private static void Main(string[] args)
    {
        const int ZONE1 = 1, ZONE2 = 2;
        const int LOW_QUANTITY = 10;
        string inputString;
        int quantity;
        int deliveryZone;
        WriteLine("Delivery is free for zone {0} or {1}",
            ZONE1, ZONE2);
        WriteLine("Enter delivery zone ");
        inputString = ReadLine();
        deliveryZone = Convert.ToInt32(inputString);
        WriteLine("Enter the number of boxes in the shipment");
        inputString = ReadLine();
        quantity = Convert.ToInt32(inputString);
        if ((deliveryZone == ZONE1 || deliveryZone == ZONE2) && quantity < LOW_QUANTITY)
                    WriteLine("Delivery is free");
        else
            WriteLine("A delivery chrage applies");


        }
    }
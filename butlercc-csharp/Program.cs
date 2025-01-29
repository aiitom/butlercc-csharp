using System;
using static System.Console;
class DemoVariables
{
    static void Main()
    {
        const double TAX_RATE = 0.06;
        string itemPriceAsString;
        double itemPrice;
        double total;
        Write("Enter the price of an item >> ");
        itemPriceAsString = ReadLine();
        itemPrice = Convert.ToDouble(itemPriceAsString);
        total = itemPrice * TAX_RATE;
        WriteLine("With a tax rate of {0}, a {1} item " +
            "cost {2} more.", TAX_RATE, itemPrice.ToString("C"), total.ToString("C"));
    }
}
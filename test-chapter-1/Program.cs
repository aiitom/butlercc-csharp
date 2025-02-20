using System;
using static System.Console;
using System.Globalization;
using System.Reflection.Metadata;
class LoopingBankBal2
{
    static void Main()
    {
        int pos100;
        int pos10;
        int pos1;
        const int MAX = 10;

        for(pos100 = 0; pos100 < MAX; ++pos100)  //Outside loop
            for(pos10 = 0; pos10 < MAX; ++pos10) //Repeats pos1 to do the same for pos100
                for(pos1 = 0;pos1 < MAX; ++pos1) //MAX is 10 so when it reaches to MAX it adds +1 to pos10
        {
            WriteLine("-----------");
            WriteLine("{0} - {1} - {2}", pos100, pos10, pos1);
            WriteLine("-----------");
            ReadLine(); //Waits for the user to press enter to move on to the next number
        }
    }
}
using static System.Console;
class DemoVariables
{
    static void Main()
    {
        int comparisonValue = 4;
        bool isSixMore = 6 > comparisonValue;
        WriteLine("When comparisonValue is {0}, isSixMore is {1}", comparisonValue, isSixMore);
        comparisonValue = 35;
        isSixMore = 6 > comparisonValue;
        WriteLine("When comparisonValue is {0}, isSixMore is {1}", comparisonValue, isSixMore);
    }
}
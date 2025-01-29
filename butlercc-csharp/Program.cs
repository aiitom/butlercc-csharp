using static System.Console;
class DemoVariables
{
    static void Main()
    {
        int hoursWorked = 36;
        double payRate = 12.35;
        double grossPay = hoursWorked * payRate;
        Console.WriteLine("The total amount I made this pay period was {0}.", grossPay);
    }
}
using System;
using static System.Console;
using static System.String;
class DemoVariables
{
    static void Main()
    {
        string name1 = "Amy";
        string name2 = "Amy";
        string name3 = "Matthew";
        Console.WriteLine("{0} to {1}; Equals() method gives {2}", name1, name2, name1.Equals(name2));
        Console.WriteLine("{0} to {1}; Equals() method gives {2}", name1, name3, name1.Equals(name3));
        Console.WriteLine("{0} to {1}; CompareTo() method gives {2}", name1, name2, name1.CompareTo(name2));
        Console.WriteLine("{0} to {1}; CompareTo() method gives {2}", name1, name2, name1.CompareTo(name3));
        Console.WriteLine("{0} to {1}; Compare() method gives {2}", name1, name2, Compare(name1,name2));
        Console.WriteLine("{0} to {1}; Compare() method gives {2}", name1, name2, Compare(name1,name3));

    }
}
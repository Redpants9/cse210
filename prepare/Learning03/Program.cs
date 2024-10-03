using System;

class Program
{
    static void Main(string[] args)
    {
        fraction f1 = new fraction();
        Console.WriteLine(f1.getfractionstring());
        Console.WriteLine(f1.getdecimalstring());

        fraction f2 = new fraction(5);
        Console.WriteLine(f2.getfractionstring());
        Console.WriteLine(f2.getdecimalstring());

        fraction f3 = new fraction(3,4);
        Console.WriteLine(f3.getfractionstring());
        Console.WriteLine(f3.getdecimalstring());

        fraction f4 = new fraction(1,3);
        Console.WriteLine(f4.getfractionstring());
        Console.WriteLine(f4.getdecimalstring());
    }
}
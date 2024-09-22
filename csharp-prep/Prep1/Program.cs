using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your first Name?");
        string first = Console.ReadLine();
        Console.Write("what is your last Name?:");
        string last =Console.ReadLine();

        Console.WriteLine($"your name is {last}, {first} {last}.");
    }
}


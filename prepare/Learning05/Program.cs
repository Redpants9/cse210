using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Nate Hansen", "c#");
        Console.WriteLine(a1.Getsummary());

        Mathassignment a2 = new Mathassignment("Heidi Hansen", "addition", ":section 1","1+1");
        Console.WriteLine(a2.Getsummary());
        Console.WriteLine(a2.gethomeworklist);

        Writingassignment a3 = new Writingassignment("Neff Hansen", "esaay", "many cool things");
        Console.WriteLine(a3.Getsummary());
        Console.WriteLine(a3.Getwritinginformation());
    }
}
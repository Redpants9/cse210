using System;

class Program
{
    static void Main(string[] args)
    {   
        Reference reference = new Reference("2 Nephi",3 ,1);
        string input = "";
        Scripture scripture = new Scripture(reference,"and now I speak unto you, Joseph my last-born. Thou wast born in the wilderness of mine afflictions; yea, in the days of my greatest sorrow did they mother bear thee.");
        while(input != "quit")
        {   
            Console.WriteLine(scripture.getdisplaytext());
            input = Console.ReadLine();
            scripture.hiderandomword();
            bool all = scripture.iscompletelyhidden();
            if(all == true)
            {
                input = "quit";
            }
            Console.Clear();
        }
    }
}
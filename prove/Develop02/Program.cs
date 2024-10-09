using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {

        int input = Menu();
        Journal journal = new Journal();
        
        while (input != 5)
        {
            if(input == 1)
            {
                DateTime theCurrentTime = DateTime.Now;
                string date = theCurrentTime.ToShortDateString();
                PromptGenerator prompt = new PromptGenerator();
                Entry entry = new Entry();
                entry.promptText = prompt.randomprompt();
                Console.WriteLine(entry.promptText);
                Console.Write(">");                                 
                entry.entryText = Console.ReadLine();
                entry.date = date;
                journal.addentry(entry);
            }
            else if(input == 2)
            {
                journal.displayall();
            }
            else if(input == 3)
            {
                Console.WriteLine("What is the name of the file? ");
                string file = Console.ReadLine();
                journal.Save(file);
            }
            else if(input == 4)
            {
                Console.WriteLine("What file do you want to load? ");
                string file = Console.ReadLine();
                journal.load(file);
            }
            else
            {
                Console.WriteLine("Sorry that wasn't a correct option");
            }
                input = Menu();

        }
    }

    private static int Menu()
    {
        Console.WriteLine("Please select from the following choices:");
        Console.WriteLine("1.Write");
        Console.WriteLine("2.Display");
        Console.WriteLine("3.Save");
        Console.WriteLine("4.Load");
        Console.WriteLine("5.Quit");
        Console.Write("What would you like to do? ");
        string response = Console.ReadLine();
        return int.Parse(response);

    }
}


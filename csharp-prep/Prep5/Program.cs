using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Security;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        displaywelcome();
        string name = promptusername();
        int number = promptusernumber();
        int number2 = squarenumber(number);
        displayresult(name, number2);   
    }
    static void displaywelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string promptusername()
    {
        Console.Write("What is your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int promptusernumber()
    {
        Console.Write("What is your favorite number: ");
        string answer = Console.ReadLine();
        int number =int.Parse(answer);
        return number;
    }
    static int squarenumber(int number)
    {
        int number2 = number * number;
        return number2;
    }
    static void displayresult(string name, int number2)
    {
        Console.WriteLine($"{name} the square of your number is {number2}");
    }
}
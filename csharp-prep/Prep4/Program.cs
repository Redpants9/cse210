using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int guess = -1;
        
        while (guess != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished. ");
            guess = int.Parse(Console.ReadLine());
            if (guess != 0)
            {
                numbers.Add(guess);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        } 
        Console.WriteLine($"The sum is the numbers is: {sum}");

        int total = numbers.Count;
        int average= sum/total;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The biggest number is: {max}");
    }
}
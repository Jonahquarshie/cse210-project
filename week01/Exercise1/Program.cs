using System;
using System.Collections.Immutable;

class Program
// first project complete.
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name?. ");
        string first = Console.ReadLine();
        
        Console.Write("what is your last name? ");
         string last = Console.ReadLine();
         
         Console.WriteLine($"your name is {last}, {first},{last}");
    }
}
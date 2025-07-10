using System;

class Program
// this is my grde calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("what is your grade percentage.");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);
        
        string letter = "A";
        if (percent >= 100)
        
        
        {
           letter = "A";
        }
        else if (percent >= 95)
        {
            letter = "B";
        }
        else if (percent >= 80)
        {
            letter = "C";
        }
        else if (percent>=50)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is: {letter}");
        
        if (percent >= 80)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        
         
    }
}
}
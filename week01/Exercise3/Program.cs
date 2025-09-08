using System;

class Program
{
    static void Main(string[] args)
    //magic game 
    //week 1 p2.
    {
        Console.WriteLine("Hello World! This is Jonah .");
         Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int guess = -3;
         while (guess != magicNumber)
    {
        Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
        if (magicNumber > guess)
    {
     Console.WriteLine("Higher");
    }
      else if (magicNumber < guess)
   {

      Console.WriteLine("Lower");
   }
   else
   {
      Console.WriteLine("You guessed it!");

   }
    }
}
}
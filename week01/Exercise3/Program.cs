using System;

class Program
{
    static void Main(string[] args)
    //magic game 
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
         Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int guess = -2;
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
using System;

public class Fract
{
    private int _top;
    private int _bottom;

    public Fract()
    {
        // Default to 1/1
        _top = 1;
        _bottom = 1;
    }

    public Fract(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1; 
    }

    public Fract(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public void Display()
    {
        Console.WriteLine($"{_top}/{_bottom}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Example usage of the Fraction class
        Fract fract1 = new Fract();
        fract1.Display();

        Fract fract2 = new Fract(5);
        fract2.Display();

        Fract fract3 = new Fract(3, 4);
          fract3.Display();
    }
}
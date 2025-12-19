using System;

class PositiveNegative
{
    static void Main()
    {
        int number;
        Console.WriteLine("Enter an integer:");
        number = Convert.ToInt32(Console.ReadLine());
        string Result = (number >= 0) ? "Positive" : "Negative";
        Console.WriteLine("The number is " + Result);

    }

}
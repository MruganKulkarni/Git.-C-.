using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter distance in feet: ");
        double feet = double.Parse(Console.ReadLine());

        double yards = feet / 3;
        double miles = yards / 1760;

        Console.WriteLine($"Distance in yards is {yards} and miles is {miles}");
    }
}

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Amar age & height: ");
        int aAge = int.Parse(Console.ReadLine());
        double aHeight = double.Parse(Console.ReadLine());

        Console.Write("Enter Akbar age & height: ");
        int bAge = int.Parse(Console.ReadLine());
        double bHeight = double.Parse(Console.ReadLine());

        Console.Write("Enter Anthony age & height: ");
        int cAge = int.Parse(Console.ReadLine());
        double cHeight = double.Parse(Console.ReadLine());

        int youngest = Math.Min(aAge, Math.Min(bAge, cAge));
        double tallest = Math.Max(aHeight, Math.Max(bHeight, cHeight));

        Console.WriteLine($"Youngest age: {youngest}");
        Console.WriteLine($"Tallest height: {tallest}");
    }
}

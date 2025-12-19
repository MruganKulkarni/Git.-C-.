using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter base: ");
        double baseVal = double.Parse(Console.ReadLine());

        Console.Write("Enter height: ");
        double height = double.Parse(Console.ReadLine());

        double area = 0.5 * baseVal * height;
        Console.WriteLine($"Area of triangle is {area}");
    }
}

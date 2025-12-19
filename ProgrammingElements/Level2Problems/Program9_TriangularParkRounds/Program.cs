using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter side 1: ");
        double s1 = double.Parse(Console.ReadLine());

        Console.Write("Enter side 2: ");
        double s2 = double.Parse(Console.ReadLine());

        Console.Write("Enter side 3: ");
        double s3 = double.Parse(Console.ReadLine());

        double perimeter = s1 + s2 + s3;
        double rounds = 5000 / perimeter;

        Console.WriteLine($"The total number of rounds the athlete will run is {rounds}");
    }
}

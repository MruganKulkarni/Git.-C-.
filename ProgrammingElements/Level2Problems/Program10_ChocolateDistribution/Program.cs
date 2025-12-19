using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of chocolates: ");
        int chocolates = int.Parse(Console.ReadLine());

        Console.Write("Enter number of children: ");
        int children = int.Parse(Console.ReadLine());

        int each = chocolates / children;
        int remaining = chocolates % children;

        Console.WriteLine($"The number of chocolates each child gets is {each} and the number of remaining chocolates is {remaining}");
    }
}

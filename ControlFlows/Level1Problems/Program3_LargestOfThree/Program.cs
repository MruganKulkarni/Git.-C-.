using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number:");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Enter third number:");
        int num3 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Is the first number the largest? {num1 > num2 && num1 > num3}");
        Console.WriteLine($"Is the second number the largest? {num2 > num1 && num2 > num3}");
        Console.WriteLine($"Is the third number the largest? {num3 > num1 && num3 > num2}");
    }
}

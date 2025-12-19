using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number: ");
        int num = int.Parse(Console.ReadLine());
        if ( num >= 0)
        {
            int sum = (num * (num + 1)) / 2;
            Console.WriteLine($"The sum of {num} natural numbers is {sum}");
        }
        else
        {
            Console.WriteLine($"The number {num} is not a natural number");
        }

    }
}
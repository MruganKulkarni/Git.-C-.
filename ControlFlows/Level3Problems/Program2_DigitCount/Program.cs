using System;

class Program
{
        static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int count = 0;
        int temp = number;
        while (temp != 0)
        {
            count++;
            temp /= 10;
        }
        Console.WriteLine($"Number of digits in {number} is {count}");
    }
}

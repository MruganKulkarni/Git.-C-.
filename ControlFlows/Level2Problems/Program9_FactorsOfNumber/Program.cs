using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Factors:");
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                Console.WriteLine(i);
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        int[] results = new int[4];
        int idx = 0;

        for (int i = 6; i <= 9; i++)
            results[idx++] = number * i;

        idx = 0;
        for (int i = 6; i <= 9; i++)
            Console.WriteLine($"{number} * {i} = {results[idx++]}");
    }
}

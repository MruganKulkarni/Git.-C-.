using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        if (number <= 0)
        {
            Console.Error.WriteLine("Not a natural number");
            Environment.Exit(0);
        }

        int[] even = new int[number / 2 + 1];
        int[] odd = new int[number / 2 + 1];
        int e = 0, o = 0;

        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0) even[e++] = i;
            else odd[o++] = i;
        }

        Console.WriteLine("Odd numbers:");
        for (int i = 0; i < o; i++) Console.WriteLine(odd[i]);

        Console.WriteLine("Even numbers:");
        for (int i = 0; i < e; i++) Console.WriteLine(even[i]);
    }
}

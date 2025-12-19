using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int originalNumber = number;
        int sum = 0;

        while (number != 0)
        {
            int digit = number % 10;
            sum += digit * digit * digit;
            number /= 10;
        }

        if (sum == originalNumber)
            Console.WriteLine($"{originalNumber} is an Armstrong Number");
        else
            Console.WriteLine($"{originalNumber} is not an Armstrong Number");
    }
}

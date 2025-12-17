using System;

class divbyfive
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int num = Convert.ToInt32(Console.ReadLine());
        // Criteria to check if number is divisible
        bool isDivisible = (num % 5 == 0);
        string condition = isDivisible? "Yes" : "No";

        Console.WriteLine($"Is the number {num} divisible by 5? {condition}");
    }
}
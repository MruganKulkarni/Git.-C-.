using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter fee: ");
        double fee = double.Parse(Console.ReadLine());

        Console.Write("Enter discount percent: ");
        double discountPercent = double.Parse(Console.ReadLine());

        double discount = fee * discountPercent / 100;
        double finalFee = fee - discount;

        Console.WriteLine($"The discount amount is INR {discount} and final discounted fee is INR {finalFee}");
    }
}

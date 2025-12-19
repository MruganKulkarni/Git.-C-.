using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter unit price: ");
        double unitPrice = double.Parse(Console.ReadLine());

        Console.Write("Enter quantity: ");
        int quantity = int.Parse(Console.ReadLine());

        double total = unitPrice * quantity;
        Console.WriteLine($"The total purchase price is INR {total} if the quantity {quantity} and unit price is INR {unitPrice}");
    }
}

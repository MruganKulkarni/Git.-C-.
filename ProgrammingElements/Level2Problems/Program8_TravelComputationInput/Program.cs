using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("From city: ");
        string fromCity = Console.ReadLine();

        Console.Write("Via city: ");
        string viaCity = Console.ReadLine();

        Console.Write("To city: ");
        string toCity = Console.ReadLine();

        Console.Write("Distance from to via: ");
        double d1 = double.Parse(Console.ReadLine());

        Console.Write("Distance via to final: ");
        double d2 = double.Parse(Console.ReadLine());

        double totalDistance = d1 + d2;

        Console.WriteLine($"The total distance travelled by {name} from {fromCity} to {toCity} via {viaCity} is {totalDistance}");
    }
}

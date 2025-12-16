using CalculatorApp;

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        Console.WriteLine("Add: " + calc.Add(10, 5));        // 15
        Console.WriteLine("Subtract: " + calc.Subtract(10, 5)); // 5
    }
}

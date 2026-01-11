using System;

class Program
{
    static void Main(string[] args)
    {
        double percent = 0.7553;
        double currency = 98765.43;
        Console.WriteLine($"Percent: {percent:P2}");
        Console.WriteLine($"Currency: {currency:C2}");
    }
}

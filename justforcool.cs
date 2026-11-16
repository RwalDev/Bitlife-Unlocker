using System;

class Program
{
    static void Main()
    {
        // Create a random number generator
        Random rand = new Random();

        // Random integer from 0 to 99
        int under100 = rand.Next(100);

        // Random integer between 1 and 6 (inclusive of 1, exclusive of 7)
        int dice = rand.Next(1, 7);

        // Random double between 0.0 and 1.0
        double fraction = rand.NextDouble();

        Console.WriteLine($"Number under 100: {under100}");
        Console.WriteLine($"You rolled a dice: {dice}");
        Console.WriteLine($"Fraction: {fraction:F4}");
    }
}

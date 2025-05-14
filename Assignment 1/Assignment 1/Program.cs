
using System;
class Program
{
    static void Main()
    {
        // Display welcome message to the user
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt the user for package weight
        Console.Write("Please enter the package weight: ");
        int weight = Convert.ToInt32(Console.ReadLine());

        // Check if the package weight is too heavy
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // End the program
        }

        // Prompt user for package dimensions
        Console.Write("Please enter the package width: ");
        int width = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter the package height: ");
        int height = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter the package length: ");
        int length = Convert.ToInt32(Console.ReadLine());

        // Check if the total dimensions exceed the limit
        int totalDimensions = width + height + length;
        if (totalDimensions > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // End the program
        }

        // Calculate the shipping quote
        int quote = (width * height * length) * weight / 100;

        // Display the final quote to the user
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote}.00");
        Console.WriteLine("Thank you!");
    }
}

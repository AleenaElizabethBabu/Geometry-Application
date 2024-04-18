using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;

class Program
{
    static async Task Main(string[] args)
    {
        var featureManagement = new Dictionary<string, string>
        {
            { "FeatureManagement:Square", "true"},
            { "FeatureManagement:Rectangle", "false"},
            { "FeatureManagement:Triangle", "true"}
        };

        IConfigurationRoot configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(featureManagement)
            .Build();

        var services = new ServiceCollection();
        services.AddFeatureManagement(configuration);
        var serviceProvider = services.BuildServiceProvider();

        var featureManager = serviceProvider.GetRequiredService<IFeatureManager>();

        if (await featureManager.IsEnabledAsync("Square"))
        {
            Console.WriteLine("Square feature is enabled.");

            // Provide access to Square
            Console.WriteLine("Enter the side length of the square:");
            double sideLength = double.Parse(Console.ReadLine());
            var square = new Square(sideLength);

            // Calculate and display area and perimeter
            Console.WriteLine($"Area of the square: {square.CalculateArea()}");
            Console.WriteLine($"Perimeter of the square: {square.CalculatePerimeter()}");
        }
        else
        {
            Console.WriteLine("Square feature is disabled.");
            // Handle case when Square feature is disabled
        }

        if (await featureManager.IsEnabledAsync("Rectangle"))
        {
            Console.WriteLine("Rectangle feature is enabled.");

            // Provide access to Rectangle
            Console.WriteLine("Enter the length of the rectangle:");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of the rectangle:");
            double width = double.Parse(Console.ReadLine());
            var rectangle = new Rectangle(length, width);

            // Calculate and display area and perimeter
            Console.WriteLine($"Area of the rectangle: {rectangle.CalculateArea()}");
            Console.WriteLine($"Perimeter of the rectangle: {rectangle.CalculatePerimeter()}");
        }
        else
        {
            Console.WriteLine("Rectangle feature is disabled.");
            // Handle case when Rectangle feature is disabled
        }

        if (await featureManager.IsEnabledAsync("Triangle"))
        {
            Console.WriteLine("Triangle feature is enabled.");

            // Provide access to Triangle
            Console.WriteLine("Enter the length of side 1 of the triangle:");
            double side1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of side 2 of the triangle:");
            double side2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of side 3 of the triangle:");
            double side3 = double.Parse(Console.ReadLine());
            var triangle = new Triangle(side1, side2, side3);

            // Calculate and display area and perimeter
            Console.WriteLine($"Area of the triangle: {triangle.CalculateArea()}");
            Console.WriteLine($"Perimeter of the triangle: {triangle.CalculatePerimeter()}");
        }
        else
        {
            Console.WriteLine("Triangle feature is disabled.");
            // Handle case when Triangle feature is disabled
        }
    }
}

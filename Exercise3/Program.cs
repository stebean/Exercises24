using System;

Console.Write("Enter the width of the rectangle: ");
double width = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the height of the rectangle: ");
double height = Convert.ToDouble(Console.ReadLine());

Rectangle rectangle = new Rectangle(width, height);

Console.WriteLine($"Perimeter: {rectangle.CalculatePerimeter()}");
Console.WriteLine($"Area: {rectangle.CalculateArea()}");
Console.WriteLine($"Diagonal: {rectangle.CalculateDiagonal()}");

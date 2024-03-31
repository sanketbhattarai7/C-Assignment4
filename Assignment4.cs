using System;

class Circle
{
    public double Radius { get; set; }
    public double X { get; set; }
    public double Y { get; set; }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }

    public bool IsPointInside(double x, double y)
    {
        double distance = Math.Sqrt(Math.Pow(x - X, 2) + Math.Pow(y - Y, 2));
        return distance <= Radius;
    }
}

class Program
{
    static Circle[] CreateCircles(int numberOfCircles)
    {
        Circle[] circles = new Circle[numberOfCircles];
        for (int i = 0; i < numberOfCircles; i++)
        {
            Console.WriteLine($"Enter radius for circle {i + 1}:");
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine($"Enter x-coordinate for circle {i + 1}:");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine($"Enter y-coordinate for circle {i + 1}:");
            double y = double.Parse(Console.ReadLine());

            circles[i] = new Circle { Radius = radius, X = x, Y = y };
        }
        return circles;
    }

    static void PrintCircleInfo(Circle circle)
    {
        Console.WriteLine($"Circle with radius {circle.Radius}:");
        Console.WriteLine($"Area: {circle.CalculateArea()}");
        Console.WriteLine($"Perimeter: {circle.CalculatePerimeter()}");
    }

    static void CheckPointInCircles(Circle[] circles, double x, double y)
    {
        for (int i = 0; i < circles.Length; i++)
        {
            Console.WriteLine($"Point ({x},{y}) {(circles[i].IsPointInside(x, y) ? "is inside" : "is outside")} circle {i + 1}");
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of circles:");
        int numberOfCircles = int.Parse(Console.ReadLine());

        Circle[] circles = CreateCircles(numberOfCircles);

        Console.WriteLine("Circle Information:");
        foreach (var circle in circles)
        {
            PrintCircleInfo(circle);
        }

        Console.WriteLine("Enter the point coordinates to check:");
        Console.WriteLine("Enter x-coordinate:");
        double xCoordinate = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter y-coordinate:");
        double yCoordinate = double.Parse(Console.ReadLine());

        CheckPointInCircles(circles, xCoordinate, yCoordinate);
    }
}
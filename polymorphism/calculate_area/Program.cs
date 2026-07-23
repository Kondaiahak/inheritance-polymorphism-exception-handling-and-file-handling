using System;

class Area
{
    public double CalculateArea(double radius)
    {
        return 3.14 * radius * radius;
    }

    public double CalculateArea(double length, double width)
    {
        return length * width;
    }

    public double CalculateArea(double b, double h, bool triangle)
    {
        return 0.5 * b * h;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Area obj = new Area();

        Console.Write("Enter Radius: ");
        double r = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Length: ");
        double l = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Width: ");
        double w = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Base: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Height: ");
        double h = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nArea of Circle    : " + obj.CalculateArea(r));
        Console.WriteLine("Area of Rectangle : " + obj.CalculateArea(l, w));
        Console.WriteLine("Area of Triangle  : " + obj.CalculateArea(b, h, true));
    }
}
using System;

class MyMath
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Subtract(int a, int b, int c)
    {
        return a - b - c;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Multiply(int a, int b, int c)
    {
        return a * b * c;
    }

    public int Divide(int a, int b)
    {
        return a / b;
    }

    public int Divide(int a, int b, int c)
    {
        return a / b / c;
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyMath obj = new MyMath();

        Console.Write("Enter First Number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Third Number: ");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nAddition of 2 Numbers      : " + obj.Add(a, b));
        Console.WriteLine("Addition of 3 Numbers      : " + obj.Add(a, b, c));

        Console.WriteLine("\nSubtraction of 2 Numbers   : " + obj.Subtract(a, b));
        Console.WriteLine("Subtraction of 3 Numbers   : " + obj.Subtract(a, b, c));

        Console.WriteLine("\nMultiplication of 2 Numbers: " + obj.Multiply(a, b));
        Console.WriteLine("Multiplication of 3 Numbers: " + obj.Multiply(a, b, c));

        Console.WriteLine("\nDivision of 2 Numbers      : " + obj.Divide(a, b));
        Console.WriteLine("Division of 3 Numbers      : " + obj.Divide(a, b, c));
    }
}
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter file name: ");
        string fileName = Console.ReadLine();

        Console.Write("Enter the content to write into the file: ");
        string content = Console.ReadLine();

        StreamWriter writer = new StreamWriter(fileName + ".txt");

        writer.WriteLine(content);

        writer.Close();

        Console.WriteLine("\nFile created successfully.");
        Console.WriteLine("Content written and file closed.");
    }
}
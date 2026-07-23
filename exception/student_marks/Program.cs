using System;

class NegativeNumberException : Exception
{
    public NegativeNumberException(string message) : base(message)
    {
    }
}

class Person
{
    public string FirstName;
    public string LastName;

    public Person(string firstName, string lastName)
    {
        if (string.IsNullOrWhiteSpace(firstName))
            throw new Exception("First Name should not be empty.");

        if (string.IsNullOrWhiteSpace(lastName))
            throw new Exception("Last Name should not be empty.");

        foreach (char ch in firstName)
        {
            if (!char.IsLetter(ch))
                throw new Exception("First Name should contain only alphabets.");
        }

        foreach (char ch in lastName)
        {
            if (!char.IsLetter(ch))
                throw new Exception("Last Name should contain only alphabets.");
        }

        FirstName = firstName;
        LastName = lastName;
    }

    public void Display()
    {
        Console.WriteLine("\nPerson Details");
        Console.WriteLine("First Name : " + FirstName);
        Console.WriteLine("Last Name  : " + LastName);
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Person Details
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Person p = new Person(firstName, lastName);

            // Student Details
            Console.Write("\nEnter Student Name: ");
            string studentName = Console.ReadLine();

            Console.Write("Enter Marks in Subject 1: ");
            int m1 = Convert.ToInt32(Console.ReadLine());

            if (m1 < 0)
                throw new NegativeNumberException("Marks cannot be negative.");

            Console.Write("Enter Marks in Subject 2: ");
            int m2 = Convert.ToInt32(Console.ReadLine());

            if (m2 < 0)
                throw new NegativeNumberException("Marks cannot be negative.");

            Console.Write("Enter Marks in Subject 3: ");
            int m3 = Convert.ToInt32(Console.ReadLine());

            if (m3 < 0)
                throw new NegativeNumberException("Marks cannot be negative.");

            Console.WriteLine("\nStudent Details");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Student Name : " + studentName);
            Console.WriteLine("Subject 1 Marks : " + m1);
            Console.WriteLine("Subject 2 Marks : " + m2);
            Console.WriteLine("Subject 3 Marks : " + m3);

            p.Display();
        }

        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter only integer values for marks.");
        }

        catch (NegativeNumberException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        finally
        {
            Console.WriteLine("\nProgram Finished.");
        }
    }
}
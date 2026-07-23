using System;

interface IPayable
{
    void CalculatePay();
}

class Person
{
    protected string firstName;
    protected string lastName;

    public Person(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public void DisplayPerson()
    {
        Console.WriteLine("Name : " + firstName + " " + lastName);
    }
}

class HourlyEmployee : Person, IPayable
{
    public double HoursWorked;
    public double PayPerHour;
    public double TotalPay;

    public HourlyEmployee(string fname, string lname, double hours, double pay)
        : base(fname, lname)
    {
        HoursWorked = hours;
        PayPerHour = pay;
    }

    public void CalculatePay()
    {
        TotalPay = HoursWorked * PayPerHour;
    }

    public void Display()
    {
        DisplayPerson();
        Console.WriteLine("Hours Worked : " + HoursWorked);
        Console.WriteLine("Pay Per Hour : " + PayPerHour);
        Console.WriteLine("Total Pay    : " + TotalPay);
    }
}

class PermanentEmployee : Person, IPayable
{
    public double BasicSalary;
    public double HRA;
    public double DA;
    public double Tax;
    public double NetPay;
    public double TotalPay;

    public PermanentEmployee(string fname, string lname, double salary)
        : base(fname, lname)
    {
        BasicSalary = salary;
    }

    public void CalculatePay()
    {
        HRA = BasicSalary * 0.15;
        DA = BasicSalary * 0.10;
        TotalPay = BasicSalary + HRA + DA;
        Tax = TotalPay * 0.08;
        NetPay = TotalPay - Tax;
    }

    public void Display()
    {
        DisplayPerson();
        Console.WriteLine("Basic Salary : " + BasicSalary);
        Console.WriteLine("HRA          : " + HRA);
        Console.WriteLine("DA           : " + DA);
        Console.WriteLine("Total Pay    : " + TotalPay);
        Console.WriteLine("Tax          : " + Tax);
        Console.WriteLine("Net Pay      : " + NetPay);
    }
}

class Program
{
    static string ReadRequiredText(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            Console.WriteLine("Please enter a value.");
        }
    }

    static double ReadDouble(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();

            if (double.TryParse(input, out double value))
            {
                return value;
            }

            Console.WriteLine("Please enter a valid number.");
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hourly Employee");

        string hfname = ReadRequiredText("First Name: ");
        string hlname = ReadRequiredText("Last Name: ");
        double hours = ReadDouble("Hours Worked: ");
        double pay = ReadDouble("Pay Per Hour: ");

        HourlyEmployee h = new HourlyEmployee(hfname, hlname, hours, pay);

        h.CalculatePay();

        Console.WriteLine("\nHourly Employee Details");
        h.Display();

        Console.WriteLine("\nPermanent Employee");

        string pfname = ReadRequiredText("First Name: ");
        string plname = ReadRequiredText("Last Name: ");
        double salary = ReadDouble("Basic Salary: ");

        PermanentEmployee p = new PermanentEmployee(pfname, plname, salary);

        p.CalculatePay();

        Console.WriteLine("\nPermanent Employee Details");
        p.Display();
    }
}
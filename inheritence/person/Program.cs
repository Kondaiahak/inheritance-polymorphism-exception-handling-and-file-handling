using System;
using System.Globalization;

class Person
{
    private string firstName;
    private string lastName;
    private string emailAddress;
    private DateTime dateOfBirth;

    public Person(string firstName, string lastName, string emailAddress, DateTime dateOfBirth)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.emailAddress = emailAddress;
        this.dateOfBirth = dateOfBirth;
    }

    public bool IsAdult
    {
        get
        {
            int age = DateTime.Now.Year - dateOfBirth.Year;

            if (DateTime.Now < dateOfBirth.AddYears(age))
                age--;

            return age >= 18;
        }
    }

    public string SunSign
    {
        get
        {
            int day = dateOfBirth.Day;
            int month = dateOfBirth.Month;

            if ((month == 3 && day >= 21) || (month == 4 && day <= 19))
                return "Aries";
            else if ((month == 4 && day >= 20) || (month == 5 && day <= 20))
                return "Taurus";
            else if ((month == 5 && day >= 21) || (month == 6 && day <= 20))
                return "Gemini";
            else if ((month == 6 && day >= 21) || (month == 7 && day <= 22))
                return "Cancer";
            else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
                return "Leo";
            else if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
                return "Virgo";
            else if ((month == 9 && day >= 23) || (month == 10 && day <= 22))
                return "Libra";
            else if ((month == 10 && day >= 23) || (month == 11 && day <= 21))
                return "Scorpio";
            else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
                return "Sagittarius";
            else if ((month == 12 && day >= 22) || (month == 1 && day <= 19))
                return "Capricorn";
            else if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
                return "Aquarius";
            else
                return "Pisces";
        }
    }

    public bool IsBirthday
    {
        get
        {
            return DateTime.Now.Day == dateOfBirth.Day &&
                   DateTime.Now.Month == dateOfBirth.Month;
        }
    }

    public string ScreenName
    {
        get
        {
            return firstName.ToLower() +
                   lastName.ToLower() +
                   dateOfBirth.Day.ToString("00") +
                   dateOfBirth.Month.ToString("00");
        }
    }

    public void Display()
    {
        Console.WriteLine("\nPerson Details");
        Console.WriteLine("------------------------");
        Console.WriteLine("First Name   : " + firstName);
        Console.WriteLine("Last Name    : " + lastName);
        Console.WriteLine("Email        : " + emailAddress);
        Console.WriteLine("Date of Birth: " + dateOfBirth.ToString("dd/MM/yyyy"));
        Console.WriteLine("Is Adult     : " + IsAdult);
        Console.WriteLine("Sun Sign     : " + SunSign);
        Console.WriteLine("Is Birthday  : " + IsBirthday);
        Console.WriteLine("Screen Name  : " + ScreenName);
    }
}

class Employee : Person
{
    public double Salary { get; set; }

    public Employee(string firstName, string lastName, string email,
        DateTime dob, double salary)
        : base(firstName, lastName, email, dob)
    {
        Salary = salary;
    }

    public void DisplayEmployee()
    {
        Display();
        Console.WriteLine("Salary       : " + Salary);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter First Name: ");
        string fname = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        string lname = Console.ReadLine();

        Console.Write("Enter Email: ");
        string email = Console.ReadLine();

        Console.Write("Enter Date of Birth (dd/MM/yyyy): ");
        DateTime dob = DateTime.ParseExact(
            Console.ReadLine(),
            "dd/MM/yyyy",
            CultureInfo.InvariantCulture);

        Console.Write("Enter Salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Employee emp = new Employee(fname, lname, email, dob, salary);

        emp.DisplayEmployee();
    }
}
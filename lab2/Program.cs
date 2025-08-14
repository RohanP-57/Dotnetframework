using System;
using System.Collections.Generic;

namespace lab2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Q1. Welcome to the User Profile and Vehicle Management System!");
            UserProfile user = new UserProfile();
            user.SetUserDetails();
            user.DisplayUserDetails();

            Console.WriteLine("\nQ2. Welcome to the Vehicle Management System!");
            Truck truck = new Truck();
            truck.SetVehicleDetails();
            truck.SetTruckDetails();
            truck.DisplayDetails();
            Bus bus = new Bus();
            bus.SetVehicleDetails();
            bus.SetBusDetails();
            bus.DisplayDetails();

            Console.WriteLine("\nQ3. Calculator with Method Overloading");
            Calculator calc = new Calculator();
            Console.WriteLine("Add(int, int): " + calc.Add(5, 10));
            Console.WriteLine("Add(float, float): " + calc.Add(5.5f, 2.3f));
            Console.WriteLine("Add(double, double, double): " + calc.Add(1.2, 3.4, 5.6));

            Console.WriteLine("\nQ4. Employee Salary Calculation");
            Employee ft = new FullTimeEmployee("John", 50000);
            Employee pt = new PartTimeEmployee("Alice", 200, 20);
            Console.WriteLine($"{ft.Name} Salary: {ft.CalculateSalary()}");
            Console.WriteLine($"{pt.Name} Salary: {pt.CalculateSalary()}");

            Console.WriteLine("\nQ5. Student Constructors");
            Student s1 = new Student();
            Student s2 = new Student("Ravi", 101);
            Student s3 = new Student("Priya", 102, 89.5);
            s1.DisplayStudentData();
            s2.DisplayStudentData();
            s3.DisplayStudentData();

            Console.WriteLine("\nQ6. Product Validation");
            Product p1 = new Product { ProductID = 1, ProductName = "Laptop", Price = 55000, Quantity = 5 };
            Product p2 = new Product { ProductID = 2, ProductName = "Mouse", Price = -200, Quantity = 10 };
            p1.DisplayProduct();
            p2.DisplayProduct();

            Console.WriteLine("\nQ7. Library Management System");
            Library lib = new Library();
            lib.RegisterMember("Rohan");
            lib.AddBook("C# Basics");
            lib.AddBook("OOP Concepts");
            lib.LendBook("Rohan", "C# Basics");
            lib.DisplayAvailableBooks();
        }
    }

    // Q1
    public class UserProfile
    {
        private string UserName;
        private string Password;
        private string email;

        public void SetUserDetails()
        {
            Console.Write("Enter Username: ");
            UserName = Console.ReadLine();
            Console.Write("Enter Password: ");
            Password = Console.ReadLine();
            Console.Write("Enter Email: ");
            email = Console.ReadLine();

            while (!email.Contains("@gmail.com"))
            {
                Console.WriteLine("Email must contain a valid email address.");
                Console.Write("Enter Email again: ");
                email = Console.ReadLine();
            }
        }
        public void DisplayUserDetails()
        {
            Console.WriteLine("\nUser Details:");
            Console.WriteLine($"Username: {UserName}");
            Console.WriteLine($"Password: {Password}");
            Console.WriteLine($"Email: {email}");
        }
    }

    // Q2
    public class Vehicle
    {
        public string Make;
        public string Model;
        public int Year;

        public void SetVehicleDetails()
        {
            Console.Write("\nEnter Vehicle Make: ");
            Make = Console.ReadLine();
            Console.Write("Enter Vehicle Model: ");
            Model = Console.ReadLine();
            Console.Write("Enter Vehicle Year: ");
            Year = int.Parse(Console.ReadLine());
            while (Year < 1900 || Year > DateTime.Now.Year)
            {
                Console.Write("Invalid year. Enter a valid year (1900 to current): ");
                Year = int.Parse(Console.ReadLine());
            }
        }
    }

    public class Truck : Vehicle
    {
        public int LoadCapacity;
        public void SetTruckDetails()
        {
            Console.Write("Enter Truck Load Capacity (in tons): ");
            LoadCapacity = int.Parse(Console.ReadLine());
        }
        public void DisplayDetails()
        {
            Console.WriteLine("\nTruck Details:");
            Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}, Load Capacity: {LoadCapacity} tons");
        }
    }

    public class Bus : Vehicle
    {
        public int SeatingCapacity;
        public void SetBusDetails()
        {
            Console.Write("Enter Bus Seating Capacity: ");
            SeatingCapacity = int.Parse(Console.ReadLine());
        }
        public void DisplayDetails()
        {
            Console.WriteLine("\nBus Details:");
            Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}, Seating Capacity: {SeatingCapacity} passengers");
        }
    }

    // Q3
    public class Calculator
    {
        public int Add(int a, int b) => a + b;
        public float Add(float a, float b) => a + b;
        public double Add(double a, double b, double c) => a + b + c;
    }

    // Q4
    public abstract class Employee
    {
        public string Name;
        public Employee(string name) { Name = name; }
        public abstract double CalculateSalary();
    }

    public class FullTimeEmployee : Employee
    {
        private double MonthlySalary;
        public FullTimeEmployee(string name, double monthlySalary) : base(name)
        {
            MonthlySalary = monthlySalary;
        }
        public override double CalculateSalary() => MonthlySalary;
    }

    public class PartTimeEmployee : Employee
    {
        private double HoursWorked;
        private double HourlyRate;
        public PartTimeEmployee(string name, double hoursWorked, double hourlyRate) : base(name)
        {
            HoursWorked = hoursWorked;
            HourlyRate = hourlyRate;
        }
        public override double CalculateSalary() => HoursWorked * HourlyRate;
    }

    // Q5
    public class Student
    {
        private string Name;
        private int RollNumber;
        private double Marks;

        public Student()
        {
            Name = "Unknown";
            RollNumber = 0;
            Marks = 0;
        }
        public Student(string name, int roll)
        {
            Name = name;
            RollNumber = roll;
            Marks = 0;
        }
        public Student(string name, int roll, double marks)
        {
            Name = name;
            RollNumber = roll;
            Marks = marks;
        }
        public void DisplayStudentData()
        {
            Console.WriteLine($"Student: {Name}, Roll: {RollNumber}, Marks: {Marks}");
        }
    }

    // Q6
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        private double price;
        public double Price
        {
            get => price;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error: Price cannot be negative.");
                    price = 0;
                }
                else price = value;
            }
        }
        public int Quantity { get; set; }

        public void DisplayProduct()
        {
            Console.WriteLine($"Product: {ProductName}, ID: {ProductID}, Price: {Price}, Quantity: {Quantity}");
        }
    }

    // Q7
    public class Book
    {
        public string Title { get; set; }
        public bool IsAvailable { get; set; } = true;
    }

    public class Member
    {
        public string Name { get; set; }
        public List<string> BorrowedBooks { get; set; } = new List<string>();
    }

    public class Library
    {
        private List<Book> books = new List<Book>();
        private List<Member> members = new List<Member>();

        public void AddBook(string title)
        {
            books.Add(new Book { Title = title });
            Console.WriteLine($"Book '{title}' added.");
        }

        public void RegisterMember(string name)
        {
            members.Add(new Member { Name = name });
            Console.WriteLine($"Member '{name}' registered.");
        }

        public void LendBook(string memberName, string bookTitle)
        {
            var member = members.Find(m => m.Name == memberName);
            var book = books.Find(b => b.Title == bookTitle && b.IsAvailable);
            if (member != null && book != null)
            {
                book.IsAvailable = false;
                member.BorrowedBooks.Add(book.Title);
                Console.WriteLine($"Book '{bookTitle}' lent to {memberName}.");
            }
            else
            {
                Console.WriteLine("Book not available or member not found.");
            }
        }

        public void DisplayAvailableBooks()
        {
            Console.WriteLine("Available Books:");
            foreach (var b in books)
            {
                if (b.IsAvailable)
                    Console.WriteLine($"- {b.Title}");
            }
        }
    }
}

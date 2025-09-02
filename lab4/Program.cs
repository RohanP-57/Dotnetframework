using System;

namespace lab4
{
    // Q1
    static class Q1_BankAccount
    {
        class BankAccount
        {
            public double Balance { get; private set; }

            public void Deposit(double amount)
            {
                Balance += amount;
            }

            public void Withdraw(double amount)
            {
                if (amount <= Balance)
                    Balance -= amount;
                else
                    Console.WriteLine("Insufficient Balance");
            }
        }

        public static void Run()
        {
            BankAccount acc = new BankAccount();
            acc.Deposit(1000);
            Console.WriteLine("Balance after deposit: " + acc.Balance);
            acc.Withdraw(500);
            Console.WriteLine("Balance after withdrawal: " + acc.Balance);
        }
    }

    // Q2
    static class Q2_Student
    {
        class Student
        {
            private int age;
            public int Age
            {
                get => age;
                set
                {
                    if (value >= 5 && value <= 25)
                        age = value;
                    else
                        age = 18;
                }
            }
        }

        public static void Run()
        {
            Student s1 = new Student { Age = 4 };
            Student s2 = new Student { Age = 20 };
            Student s3 = new Student { Age = 30 };

            Console.WriteLine($"Age=4 → Stored: {s1.Age}");
            Console.WriteLine($"Age=20 → Stored: {s2.Age}");
            Console.WriteLine($"Age=30 → Stored: {s3.Age}");
        }
    }

    // Q3
    static class Q3_Employee
    {
        class Employee
        {
            private double basicSalary;
            public double BasicSalary
            {
                set { basicSalary = value; }
            }

            public double TotalSalary => basicSalary + (0.2 * basicSalary);
        }

        public static void Run()
        {
            Employee emp = new Employee();
            emp.BasicSalary = 30000;
            Console.WriteLine("Total Salary: " + emp.TotalSalary);
        }
    }

    // Q4
    static class Q4_Product
    {
        class Product
        {
            public double Price { get; set; }
            public double Discount { get; set; }

            public double FinalPrice()
            {
                return Price - (Price * Discount / 100);
            }
        }

        public static void Run()
        {
            Product p = new Product { Price = 2000, Discount = 10 };
            Console.WriteLine("Final Price: " + p.FinalPrice());
        }
    }

    // Q5
    static class Q5_Car
    {
        class Car
        {
            private int speed;
            public int Speed
            {
                get => speed;
                set
                {
                    if (value > 180)
                        speed = 180;
                    else
                        speed = value;
                }
            }
        }

        public static void Run()
        {
            Car c = new Car();
            c.Speed = 150;
            Console.WriteLine("Speed set to 150 → " + c.Speed);
            c.Speed = 200;
            Console.WriteLine("Speed set to 200 → " + c.Speed);
        }
    }

    // Q6
    static class Q6_OperationDelegate
    {
        delegate int Operation(int a, int b);

        static int Add(int a, int b) => a + b;
        static int Subtract(int a, int b) => a - b;

        public static void Run()
        {
            Console.Write("Enter first number: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int n2 = int.Parse(Console.ReadLine());

            Operation op1 = Add;
            Operation op2 = Subtract;

            Console.WriteLine("Addition: " + op1(n1, n2));
            Console.WriteLine("Subtraction: " + op2(n1, n2));
        }
    }

    // Q7
    static class Q7_FormatTextDelegate
    {
        delegate string FormatText(string input);

        static string ToUpperCase(string str) => str.ToUpper();
        static string ToLowerCase(string str) => str.ToLower();

        public static void Run()
        {
            string text = "Hello World";
            FormatText f1 = ToUpperCase;
            FormatText f2 = ToLowerCase;

            Console.WriteLine("Uppercase: " + f1(text));
            Console.WriteLine("Lowercase: " + f2(text));
        }
    }

    // Q8
    static class Q8_BillingDelegate
    {
        delegate double BillingOperation(double amount);

        static double ShowTotal(double amt)
        {
            Console.WriteLine("Original Price: " + amt);
            return amt;
        }

        static double ApplyDiscount(double amt)
        {
            double discounted = amt - (amt * 0.10);
            Console.WriteLine("After 10% Discount: " + discounted);
            return discounted;
        }

        static double AddTax(double amt)
        {
            double taxed = amt + (amt * 0.18);
            Console.WriteLine("After 18% GST: " + taxed);
            return taxed;
        }

        static double FinalBill(double amt)
        {
            Console.WriteLine("Final Payable: " + amt);
            return amt;
        }

        public static void Run()
        {
            double amount = 5000;
            double result = amount;

            result = ShowTotal(result);
            result = ApplyDiscount(result);
            result = AddTax(result);
            result = FinalBill(result);
        }
    }

    // Q9
    static class Q9_TemperatureDelegate
    {
        delegate double ConvertTemperature(double celsius);

        static double ToFahrenheit(double c) => (c * 9 / 5) + 32;
        static double ToKelvin(double c) => c + 273.15;

        public static void Run()
        {
            double celsius = 25;
            ConvertTemperature f = ToFahrenheit;
            ConvertTemperature k = ToKelvin;

            Console.WriteLine("25°C in Fahrenheit: " + f(celsius));
            Console.WriteLine("25°C in Kelvin: " + k(celsius));
        }
    }

    // Q10
    static class Q10_NotifierDelegate
    {
        delegate void Notifier(string message);

        static void SendEmail(string msg) => Console.WriteLine("Email Sent: " + msg);
        static void SendSMS(string msg) => Console.WriteLine("SMS Sent: " + msg);

        public static void Run()
        {
            Notifier notify = SendEmail;
            notify += SendSMS;

            notify("Assignment Submitted Successfully");
        }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Q1 Output:");
            Q1_BankAccount.Run();
            Console.WriteLine("\nQ2 Output:");
            Q2_Student.Run();
            Console.WriteLine("\nQ3 Output:");
            Q3_Employee.Run();
            Console.WriteLine("\nQ4 Output:");
            Q4_Product.Run();
            Console.WriteLine("\nQ5 Output:");
            Q5_Car.Run();
            Console.WriteLine("\nQ6 Output:");
            Q6_OperationDelegate.Run();
            Console.WriteLine("\nQ7 Output:");
            Q7_FormatTextDelegate.Run();
            Console.WriteLine("\nQ8 Output:");
            Q8_BillingDelegate.Run();
            Console.WriteLine("\nQ9 Output:");
            Q9_TemperatureDelegate.Run();
            Console.WriteLine("\nQ10 Output:");
            Q10_NotifierDelegate.Run();
        }
    }
}

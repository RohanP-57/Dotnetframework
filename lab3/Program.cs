using System;

namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ================== Question 1 Testing ==================
            Employee emp = new Employee();
            emp.Name = "Rohan.P";
            emp.Age = 25;
            emp.Salary = 6000;
            emp.DisplayDetails();

            emp.Name = "Roha"; // Testing name validation
            emp.DisplayDetails();

            // ================== Question 2 Testing ==================
            BankAccount acc = new BankAccount();
            acc.AccountNumber = "ACC12345";
            acc.AccountHolderName = "Rohan.P";
            acc.Deposit(10000);
            acc.Withdraw(3000);
            acc.DisplayAccountDetails();
            acc.Withdraw(8000);// Testing withdrawal beyond balance

            // ================== Question 3 Testing ==================
            int[] numbers = { 10, 20, 30, 40, 50 };
            double average = MathHelper.CalculateAverage(numbers);
            Console.WriteLine("\n--- Question 3 ---");
            Console.WriteLine($"Average of the array: {average}");

            // ================== Question 4 Testing ==================
            Logger.LogMessage("This is a log message for Question 4.");

        }
    }

    // ================== Question 1 ==================
    class Employee
    {
        string name;
        int age, salary;

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 5)
                {
                    while (value.Length <= 5)
                    {
                        Console.WriteLine("Name must be more than 5 characters");
                        Console.Write("Enter a valid name: ");
                        value = Console.ReadLine();
                    }
                }
                name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 18)
                {
                    while (value <= 18)
                    {
                        Console.WriteLine("Age must be more than 18:");
                        Console.Write("Enter a valid Age: ");
                        value = int.Parse(Console.ReadLine());
                    }
                }
                age = value;
            }
        }

        public int Salary
        {
            get { return salary; }
            set
            {
                if (value <= 5000)
                {
                    while (value <= 5000)
                    {
                        Console.WriteLine("Salary must be more than 5000:");
                        Console.Write("Enter a valid Salary: ");
                        value = int.Parse(Console.ReadLine());
                    }
                }
                salary = value;
            }
        }

        // Display method for Employee
        public void DisplayDetails()
        {
            Console.WriteLine("\n--- Question 1 ---");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Salary: " + Salary);
        }
    }

    // ================== Question 2 ==================
    class BankAccount
    {
        string accountNumber;
        string accountHolderName;
        double balance;

        public string AccountNumber
        {
            get { return accountNumber; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Account number cannot be empty.");
                }
                else
                {
                    accountNumber = value;
                }
            }
        }

        public string AccountHolderName
        {
            get { return accountHolderName; }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Account holder name must be at least 3 characters.");
                }
                else
                {
                    accountHolderName = value;
                }
            }
        }

        public double Balance
        {
            get { return balance; }
            private set { balance = value; }
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited {amount}. New Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
            }
            else if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance!");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount}. New Balance: {Balance}");
            }
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("\n--- Question 2 ---");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder: {AccountHolderName}");
            Console.WriteLine($"Balance: {Balance}");
        }
    }
    //==================Question 3==================
    public static class MathHelper { 
        public static double CalculateAverage(int[] numbers) 
        {
            if (numbers == null || numbers.Length == 0) { 
                Console.WriteLine("Array is empty or null. Cannot calculate average.");
                return 0;
            }
            
            int sum=0;
            for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return (double)sum / numbers.Length;

        }
    }
    //==================Question 4==================
    public static class Logger
    {
        public static void LogMessage(string message)
        { 
            Console.WriteLine($"[{DateTime.Now}] {message}");
        }
    }

    //==================Question 5==================
    public partial class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

}

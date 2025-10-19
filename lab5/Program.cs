using System;

// --- Custom Exception Classes ---
class NegativeSalaryException : Exception
{
    public NegativeSalaryException(string message) : base(message) { }
}

class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message) { }
}

class InvalidMarksException : Exception
{
    public InvalidMarksException(string message) : base(message) { }
}

// --- Main Program ---
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n================= Exception Handling Menu =================");
            Console.WriteLine("1. Handling Division by Zero");
            Console.WriteLine("2. Multiple Catch Blocks");
            Console.WriteLine("3. Custom Exception — NegativeSalaryException");
            Console.WriteLine("4. Banking Scenario — InsufficientBalanceException");
            Console.WriteLine("5. Student Marks Validation — InvalidMarksException");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option (1–6): ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    DivisionByZero();
                    break;
                case "2":
                    MultipleCatch();
                    break;
                case "3":
                    NegativeSalary();
                    break;
                case "4":
                    BankingScenario();
                    break;
                case "5":
                    StudentMarksValidation();
                    break;
                case "6":
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice! Please try again.\n");
                    break;
            }
        }
    }

    // Q1: Division by Zero
    static void DivisionByZero()
    {
        try
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 / num2;
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Division by zero is not allowed.");
        }
        finally
        {
            Console.WriteLine("Execution completed.\n");
        }
    }

    // Q2: Multiple Catch Blocks
    static void MultipleCatch()
    {
        try
        {
            Console.Write("Enter a number: ");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine($"You entered: {value}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid format. Please enter numeric values only.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Number too large or too small for an Int32.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }

    // Q3: Custom Exception — NegativeSalaryException
    static void NegativeSalary()
    {
        try
        {
            Console.Write("Enter salary amount: ");
            double salary = double.Parse(Console.ReadLine());

            if (salary < 0)
                throw new NegativeSalaryException("Salary cannot be negative!");

            Console.WriteLine($"Valid salary: {salary}");
        }
        catch (NegativeSalaryException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }

    // Q4: Banking Scenario — InsufficientBalanceException
    static void BankingScenario()
    {
        double balance = 5000; // Initial balance
        try
        {
            Console.WriteLine($"Current Balance: {balance}");
            Console.Write("Enter withdrawal amount: ");
            double withdraw = double.Parse(Console.ReadLine());

            if (withdraw > balance)
                throw new InsufficientBalanceException("Insufficient balance for this withdrawal!");

            balance -= withdraw;
            Console.WriteLine($"Withdrawal successful. Remaining balance: {balance}");
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }

    // Q5: Student Marks Validation — InvalidMarksException
    static void StudentMarksValidation()
    {
        try
        {
            Student s = new Student();
            Console.Write("Enter student marks: ");
            s.Marks = int.Parse(Console.ReadLine());

            Console.WriteLine($"Valid marks: {s.Marks}");
        }
        catch (InvalidMarksException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }
}

// --- Supporting Class for Q5 ---
class Student
{
    private int marks;

    public int Marks
    {
        get { return marks; }
        set
        {
            if (value < 0 || value > 100)
                throw new InvalidMarksException("Marks must be between 0 and 100.");
            marks = value;
        }
    }
}

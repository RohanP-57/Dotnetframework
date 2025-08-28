using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assingment_3
{
        internal class Program
        {
            static void Main(string[] args)
            {
            // Question 1
              Employee emp = new Employee
                  {
                      Name = "Alice",
                      Age = 30,
                      Salary = 50000m
                  };
                  emp.DisplayDetails();
                  Console.WriteLine();

                  //Question 2
                  BankAccount account = new BankAccount("123456", "Alice", 1000m);
                  account.DisplayDetails();
                  account.Deposit(500m);
                  account.Withdraw(200m);
                  account.DisplayDetails();
                  Console.ReadLine();

              //Question 3
              int[] values = { 10, 20, 30, 40, 50 };
              double average = MathHelper.CalculateAverage(values);
              Console.WriteLine($"Average: {average}");
              
            //Question 4
           
                int[] values = { 10, 20, 30, 40, 50 };
                double average = MathHelper.CalculateAverage(values);
                Console.WriteLine($"Average: {average}");
                Logger.LogMessage("Calculated average of integer array.");
      
            // Question 5
                Person person = new Person
                {
                FirstName = "John",
                LastName = "Doe"
                };
               person.PrintFullName();
            
            // Question 6
            Employee1 emp = new Employee1
            {
                Name = "Bob",
                Age = 40,
                BaseSalary = 60000m,
                Bonus = 5000m,
                Deductions = 3000m
            };
            Console.WriteLine($"Gross Salary: {emp.CalculateGrossSalary():C}");
            Console.WriteLine($"Net Salary: {emp.CalculateNetSalary():C}");
            
            // Question 7
            Shape circle = new Circle(5); 
            Console.WriteLine($"Circle Area: {circle.CalculateArea():F2}");

            Shape rectangle = new Rectangle(4, 6); 
            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea():F2}");
            
            // Question 8
            Dog dog = new Dog { Name = "Buddy", Age = 3 };
            dog.Speak();      
            dog.Fetch();      

            Cat cat = new Cat { Name = "Whiskers", Age = 2 };
            cat.Speak();      
            cat.Scratch();
            
            // Question 9
            Vehicle vehicle = new Vehicle();
            vehicle.StartEngine();   
            vehicle.StopEngine();   

            Car car = new Car();
            car.StartEngine();       
            car.StopEngine();        

            // Question 10
            SavingsAccount savings = new SavingsAccount("SA123", 1000m, 5m); 
            savings.DisplayDetails();
            savings.Deposit(500m);
            savings.ApplyInterest(6); 
            savings.Withdraw(200m);
            savings.DisplayDetails();

        }
    }
    }

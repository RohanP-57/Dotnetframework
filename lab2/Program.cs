using System;

namespace lab2
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Q1. Welcome to the User Profile and Vehicle Management System!");
            Q1UserProfile user = new Q1UserProfile();
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


        }
    }
    public class Q1UserProfile
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
            Year=int.Parse(Console.ReadLine());
            while (Year < 1900 || Year > DateTime.Now.Year)
            {
                Console.Write("Invalid year. Enter a valid year (1900 to current): ");
                Year = int.Parse(Console.ReadLine());
            }
        }

    }

    // Derived class: Truck
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


    // Derived class: Bus
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

}


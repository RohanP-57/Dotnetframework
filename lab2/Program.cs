using System;

namespace lab2
{
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

    public class Program
    {
        public static void Main(string[] args)
        {
            Q1UserProfile user = new Q1UserProfile();
            user.SetUserDetails();               
            user.DisplayUserDetails();           
        }
    }
}